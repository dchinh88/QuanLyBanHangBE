using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{ 
    public class DonhangDTO : BaseEntities
    {
        public int Id { get; set; }

        public DateTime? Ngaytaodon { get; set; }

        public string? Diachigiaohang { get; set; }

        public int? Khachhangid { get; set; }

        public int? Nhanvienid { get; set; }

        public int? Tinhtrangid { get; set; }

        public decimal? Thanhtien { get; set; }

        public decimal? Dathanhtoan { get; set; }

        public decimal? Conno { get; set; }
    }
}
