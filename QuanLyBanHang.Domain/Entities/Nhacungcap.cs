using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Nhacungcap
{
    public int Id { get; set; }

    public string? Tennhacungcap { get; set; }

    public string? Diachi { get; set; }

    public string? Sodienthoai { get; set; }

    public string? Email { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Phieumuahang> Phieumuahangs { get; set; } = new List<Phieumuahang>();
}
