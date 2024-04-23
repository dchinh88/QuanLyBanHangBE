using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Donhang
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

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; } = new List<Chitietdonhang>();

    public virtual ICollection<Congnocuakhachhang> Congnocuakhachhangs { get; set; } = new List<Congnocuakhachhang>();

    public virtual Khachhang? Khachhang { get; set; }

    public virtual Nhanvien? Nhanvien { get; set; }

    public virtual Tinhtrang? Tinhtrang { get; set; }
}
