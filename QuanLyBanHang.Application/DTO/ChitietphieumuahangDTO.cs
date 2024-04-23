using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class ChitietphieumuahangDTO : BaseEntities
    {
        public int Id { get; set; }

        public int? Phieumuahangid { get; set; }

        public string? Tensanpham { get; set; }

        public int? Soluong { get; set; }

        public decimal? Dongia { get; set; }
    }
}
