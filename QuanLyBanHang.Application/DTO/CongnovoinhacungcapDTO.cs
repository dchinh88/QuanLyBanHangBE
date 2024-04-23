using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class CongnovoinhacungcapDTO : BaseEntities
    {
        public int Id { get; set; }

        public int? Phieumuahangid { get; set; }

        public string? Tennhacungcap { get; set; }

        public decimal? Tongtienphaithanhtoa { get; set; }

        public decimal? Sotiendathanhtoan { get; set; }

        public decimal? Sotienconno { get; set; }

        public DateTime? Hanthanhtoan { get; set; }
    }
}
