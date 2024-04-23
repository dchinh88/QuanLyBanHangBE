using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class PhieumuahangDTO
    {
        public int Id { get; set; }

        public int? Nhacungcapid { get; set; }

        public int? Nhanvienid { get; set; }

        public DateTime? Ngaymuahang { get; set; }

        public decimal? Tongtien { get; set; }
    }
}
