using System;
using System.Collections.Generic;

namespace QuanLyBanHang.Domain.Entities;

public partial class Tinhtrang
{
    public int Id { get; set; }

    public string? Tentinhtrang { get; set; }

    public DateTime? Createdat { get; set; }

    public DateTime? Updatedat { get; set; }

    public DateTime? Deletedat { get; set; }

    public int? Deletedby { get; set; }

    public int? Updatedby { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();
}
