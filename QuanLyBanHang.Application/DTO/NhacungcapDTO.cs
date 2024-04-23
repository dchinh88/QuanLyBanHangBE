using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class NhacungcapDTO : BaseEntities
    {
        public int Id { get; set; }

        public string? Tennhacungcap { get; set; }

        public string? Diachi { get; set; }

        public string? Sodienthoai { get; set; }

        public string? Email { get; set; }
    }
}
