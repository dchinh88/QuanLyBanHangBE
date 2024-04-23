using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class SanphamDTO : BaseEntities
    {
        public int Id { get; set; }

        public int? Loaisanphamid { get; set; }

        public string? Tensanpham { get; set; }

        public decimal? Giaban { get; set; }

        public string? Chatlieu { get; set; }

        public string? Macsac { get; set; }

        public string? Baohanh { get; set; }

        public string? Mota { get; set; }

        public int? Khoid { get; set; }

        public int? Soluongton { get; set; }
    }
}
