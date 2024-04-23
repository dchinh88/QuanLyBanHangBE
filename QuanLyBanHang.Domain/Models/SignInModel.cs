using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Domain.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Username không được để trống"), EmailAddress]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Username không được để trống")]
        [MinLength(8, ErrorMessage = "Mật khẩu tối thiểu 8 kí tự")]
        public string Password { get; set; } = null!;
    }
}
