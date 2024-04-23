using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Khachhang
{
    public int Id { get; set; }

    public string? Hoten { get; set; }

    public string? Diachi { get; set; }

    public string? Sodienthoai { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();
}
