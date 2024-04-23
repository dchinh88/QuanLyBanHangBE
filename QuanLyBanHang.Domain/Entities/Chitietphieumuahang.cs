using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Chitietphieumuahang
{
    public int Id { get; set; }

    public int? Phieumuahangid { get; set; }

    public string? Tensanpham { get; set; }

    public int? Soluong { get; set; }

    public decimal? Dongia { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual Phieumuahang? Phieumuahang { get; set; }
}
