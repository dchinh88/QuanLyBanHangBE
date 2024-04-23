using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Congnovoinhacungcap
{
    public int Id { get; set; }

    public int? Phieumuahangid { get; set; }

    public string? Tennhacungcap { get; set; }

    public decimal? Tongtienphaithanhtoa { get; set; }

    public decimal? Sotiendathanhtoan { get; set; }

    public decimal? Sotienconno { get; set; }

    public DateTime? Hanthanhtoan { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual Phieumuahang? Phieumuahang { get; set; }
}
