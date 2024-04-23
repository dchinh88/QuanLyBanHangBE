using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Avatar
{
    public int Id { get; set; }

    public int? Nhanvienid { get; set; }

    public byte[]? Avatar1 { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual Nhanvien? Nhanvien { get; set; }
}
