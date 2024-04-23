using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Nhanvien
{
    public int Id { get; set; }

    public string? Tennhanvien { get; set; }

    public string? Diachi { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Sodienthoai { get; set; }

    public string? Email { get; set; }

    public string? Matkhau { get; set; }

    public string? Chucvu { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Avatar> Avatars { get; set; } = new List<Avatar>();

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();

    public virtual ICollection<Phieumuahang> Phieumuahangs { get; set; } = new List<Phieumuahang>();
}
