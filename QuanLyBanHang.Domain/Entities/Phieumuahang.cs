using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Phieumuahang
{
    public int Id { get; set; }

    public int? Nhacungcapid { get; set; }

    public int? Nhanvienid { get; set; }

    public DateTime? Ngaymuahang { get; set; }

    public decimal? Tongtien { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Chitietphieumuahang> Chitietphieumuahangs { get; set; } = new List<Chitietphieumuahang>();

    public virtual ICollection<Congnovoinhacungcap> Congnovoinhacungcaps { get; set; } = new List<Congnovoinhacungcap>();

    public virtual Nhacungcap? Nhacungcap { get; set; }

    public virtual Nhanvien? Nhanvien { get; set; }
}
