using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Congnocuakhachhang
{
    public int Id { get; set; }

    public int? Donhangid { get; set; }

    public string? Hoten { get; set; }

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

    public virtual Donhang? Donhang { get; set; }
}
