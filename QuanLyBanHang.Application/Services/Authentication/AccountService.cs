using CommonHelper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Helper;
using QuanLyBanHang.Application.Interface.IAuthentication;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Models;
using QuanLyBanHang.Domain.Repositories;
using QuanLyBanHang.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Services.Authentication
{
    public class AccountService : IAccountService
    {
        private readonly QlkinhdoanhContext _context;
        private readonly IConfiguration configuration;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountService(QlkinhdoanhContext context, IConfiguration configuration, SignInManager<ApplicationUser> signInManager, INhanvienRepositories nhanvien)
        {
            _context = context;
            this.configuration = configuration;
            this.signInManager = signInManager;
        }

        /*public dynamic refreshToken(string token)
        {

        }*/

        public dynamic Login(string username, string password)
        {
            try
            {
                SHA256 hash = SHA256.Create();
                var user = _context.Nhanviens.FirstOrDefault(u => u.Email == username);
                /*var avt = _context.Avatars.FirstOrDefault(i => i.Nhanvienid == user.Id);*/

                if (user == null || !HashPassword.VerifyHash(hash, password, user.Matkhau))
                {
                    return string.Empty;
                }
                
                return new
                {
                    accessToken = new
                    {
                        token = this.GenerateToken(user, JwtContant.expiresIn),
                        expires = JwtContant.expiresIn,
                        role = user.Chucvu,
                        iduser = user.Id,
                       avatar = GetAvatarByUserId(user.Id)
                    },
                    refreshToken = new
                    {
                        token = this.GenerateToken(user, JwtContant.refresh_expiresIn),
                        expiresIn = JwtContant.refresh_expiresIn
                    }
                };
            }
            catch (Exception ex)
            {
                throw new CommonException("Error login", 500, ex);
            }
        }

        private string GenerateToken(Nhanvien nhanvien, int time)
        {
            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var authClaims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, nhanvien.Id.ToString()),
                new Claim(ClaimTypes.Email, nhanvien.Email),
                new Claim(JwtRegisteredClaimNames.Email, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, nhanvien.Chucvu.ToString()) //Them claim role
            };

            var token = new JwtSecurityToken
            (
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddSeconds(time), //thoi gian het han cua token
                notBefore: DateTime.Now,
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha256)
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        /*public dynamic refreshToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadToken(token) as JwtSecurityToken;

                if (jwtToken == null)
                {
                    throw new SecurityTokenException("Invalid token");
                }
                var email = jwtToken.Claims.First(claim => claim.Type == ClaimTypes.Email)?.Value;
                var user = _context.Nhanviens.FirstOrDefault(u => u.Email == email);
                if (user == null)
                {
                    throw new SecurityTokenException("User not found");
                }
                var newAccessToken = new
                {
                    token = GenerateToken(user, JwtContant.expiresIn),
                    expires = JwtContant.expiresIn,
                    role = user.Chucvu
                };

                var newRefreshToken = new
                {
                    token = GenerateToken(user, JwtContant.refresh_expiresIn),
                    expiresIn = JwtContant.refresh_expiresIn
                };
                return new
                {
                    accessToken = newAccessToken,
                    refreshToken = newRefreshToken
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new CommonException("Error refreshing token", 500, ex);
            }
        }*/

        public dynamic refreshToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadToken(token) as JwtSecurityToken;

                if (jwtToken == null)
                {
                    throw new SecurityTokenException("Invalid token");
                }

                var email = jwtToken.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)?.Value;
                if (email == null)
                {
                    throw new SecurityTokenException("Email claim not found in token");
                }

                var user = _context.Nhanviens.FirstOrDefault(u => u.Email == email);
                if (user == null)
                {
                    throw new SecurityTokenException("User not found");
                }

                var newAccessToken = new
                {
                    token = GenerateToken(user, JwtContant.expiresIn),
                    expires = JwtContant.expiresIn,
                    role = user.Chucvu
                };

                var newRefreshToken = new
                {
                    token = GenerateToken(user, JwtContant.refresh_expiresIn),
                    expiresIn = JwtContant.refresh_expiresIn
                };

                return new
                {
                    accessToken = newAccessToken,
                    refreshToken = newRefreshToken
                };
            }
            catch (SecurityTokenException ex)
            {
                Console.WriteLine(ex.Message);
                throw new CommonException("Security token error", 401, ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new CommonException("Error refreshing token", 500, ex);
            }
        }

        public bool verifyToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadToken(token) as JwtSecurityToken;
                if (jwtToken == null)
                {
                    return false;
                }
                return jwtToken.ValidTo < DateTime.UtcNow;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private byte[] GetAvatarByUserId(int id)
        {
            var avatar = _context.Avatars.FirstOrDefault(x => x.Nhanvienid == id);
            if(avatar != null)
            {
                return avatar.Avatar1;
            }
            return null;
        }
    }
}
