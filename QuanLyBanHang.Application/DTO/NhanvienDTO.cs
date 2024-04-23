using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Domain.Common;

namespace QuanLyBanHang.Application.DTO
{
    public class NhanvienDTO : BaseEntities
    {
        public int Id { get; set; }

        public string? Tennhanvien { get; set; }

        public string? Diachi { get; set; }

        public DateTime? Ngaysinh { get; set; }

        public string? Sodienthoai { get; set; }

        public string? Email { get; set; }

        public string? Matkhau { get; set; }

        public string? Chucvu { get; set; }
    }
}
