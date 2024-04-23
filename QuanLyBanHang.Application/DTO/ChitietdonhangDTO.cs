using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class ChitietdonhangDTO
    {
        public int Id { get; set; }

        public int? Donhangid { get; set; }

        public int? Sanphamid { get; set; }

        public int? Soluong { get; set; }

        public decimal? Dongia { get; set; }
    }
}
