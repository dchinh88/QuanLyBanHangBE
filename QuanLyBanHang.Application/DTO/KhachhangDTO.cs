using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class KhachhangDTO : BaseEntities
    {
        public int Id { get; set; }

        public string? Hoten { get; set; }

        public string? Diachi { get; set; }

        public string? Sodienthoai { get; set; }
    }
}
