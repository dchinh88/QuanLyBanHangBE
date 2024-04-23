using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Chitietdonhang
{
    public int Id { get; set; }

    public int? Donhangid { get; set; }

    public int? Sanphamid { get; set; }

    public int? Soluong { get; set; }

    public decimal? Dongia { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual Donhang? Donhang { get; set; }

    public virtual Sanpham? Sanpham { get; set; }
}
