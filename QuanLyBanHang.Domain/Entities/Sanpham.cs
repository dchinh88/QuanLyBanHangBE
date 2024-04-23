using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Sanpham
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

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; } = new List<Chitietdonhang>();

    public virtual ICollection<Imagesanpham> Imagesanphams { get; set; } = new List<Imagesanpham>();

    public virtual Kho? Kho { get; set; }

    public virtual Loaisanpham? Loaisanpham { get; set; }
}
