using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.IdentityModel.Tokens;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface.IAuthentication;
using QuanLyBanHang.Domain.Models;

namespace QuanLyBanHang.API.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService account;
        public AccountController(IAccountService account)
        {
            this.account = account;
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody]SignInModel model)
        {
            try
            {
                var user = account.Login(model.Email, model.Password);
                if(user != string.Empty)
                {
                    return Ok(new
                    {
                        Message = "Login Successful!",
                        User = user
                    });
                }
                return BadRequest("Login Faild!");
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*[HttpPost("refresh")]
        public IActionResult sendRefreshToken(string token)
        {
            try
            {
                var decodeToken = account.verifyToken(token);
                if(!decodeToken)
                {
                    var newRefreshToken = account.refreshToken(token);
                    return newRefreshToken;
                }
                else
                {
                    throw new Exception("Invalid refresh Token");
                }
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }*/

        [HttpPost("refresh")]
        public IActionResult SendRefreshToken(string token)
        {
            try
            {
                var decodedToken = account.verifyToken(token);
                if (!decodedToken)
                {
                    var newTokens = account.refreshToken(token);
                    return Ok(newTokens);
                }
                else
                {
                    throw new SecurityTokenException("Invalid refresh token");
                }
            }
            catch (SecurityTokenException ex)
            {
                Console.WriteLine(ex.Message);
                return Unauthorized(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
