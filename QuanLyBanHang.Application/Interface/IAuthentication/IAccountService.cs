using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface.IAuthentication
{
    public interface IAccountService
    {
        dynamic Login(string username, string password);
        dynamic refreshToken(string token);
        bool verifyToken(string token);
    }
}
