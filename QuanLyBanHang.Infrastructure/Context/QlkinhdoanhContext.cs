using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Domain.Entities;

namespace QuanLyBanHang.Infrastructure.Context;

public partial class QlkinhdoanhContext : DbContext
{
    public QlkinhdoanhContext()
    {
    }

    public QlkinhdoanhContext(DbContextOptions<QlkinhdoanhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avatar> Avatars { get; set; }

    public virtual DbSet<Chitietdonhang> Chitietdonhangs { get; set; }

    public virtual DbSet<Chitietphieumuahang> Chitietphieumuahangs { get; set; }

    public virtual DbSet<Congnocuakhachhang> Congnocuakhachhangs { get; set; }

    public virtual DbSet<Congnovoinhacungcap> Congnovoinhacungcaps { get; set; }

    public virtual DbSet<Donhang> Donhangs { get; set; }

    public virtual DbSet<Imagesanpham> Imagesanphams { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kho> Khos { get; set; }

    public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phieumuahang> Phieumuahangs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Tinhtrang> Tinhtrangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=QLKINHDOANH;UID=sa;PWD=ducchinh;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avatar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AVATAR__3214EC27B1419861");

            entity.ToTable("AVATAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Avatar1)
                .HasColumnType("image")
                .HasColumnName("AVATAR");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Nhanvienid).HasColumnName("NHANVIENID");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Nhanvien).WithMany(p => p.Avatars)
                .HasForeignKey(d => d.Nhanvienid)
                .HasConstraintName("FK__AVATAR__NHANVIEN__3C69FB99");
        });

        modelBuilder.Entity<Chitietdonhang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHITIETD__3214EC275F4960B2");

            entity.ToTable("CHITIETDONHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Dongia)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DONGIA");
            entity.Property(e => e.Donhangid).HasColumnName("DONHANGID");
            entity.Property(e => e.Sanphamid).HasColumnName("SANPHAMID");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Donhang).WithMany(p => p.Chitietdonhangs)
                .HasForeignKey(d => d.Donhangid)
                .HasConstraintName("FK__CHITIETDO__DONHA__5441852A");

            entity.HasOne(d => d.Sanpham).WithMany(p => p.Chitietdonhangs)
                .HasForeignKey(d => d.Sanphamid)
                .HasConstraintName("FK__CHITIETDO__SANPH__5535A963");
        });

        modelBuilder.Entity<Chitietphieumuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHITIETP__3214EC272D89F422");

            entity.ToTable("CHITIETPHIEUMUAHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Dongia)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DONGIA");
            entity.Property(e => e.Phieumuahangid).HasColumnName("PHIEUMUAHANGID");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Tensanpham)
                .HasMaxLength(50)
                .HasColumnName("TENSANPHAM");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Phieumuahang).WithMany(p => p.Chitietphieumuahangs)
                .HasForeignKey(d => d.Phieumuahangid)
                .HasConstraintName("FK__CHITIETPH__PHIEU__619B8048");
        });

        modelBuilder.Entity<Congnocuakhachhang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONGNOCU__3214EC27D50F88C9");

            entity.ToTable("CONGNOCUAKHACHHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Donhangid).HasColumnName("DONHANGID");
            entity.Property(e => e.Hanthanhtoan)
                .HasColumnType("datetime")
                .HasColumnName("HANTHANHTOAN");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Sotienconno)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SOTIENCONNO");
            entity.Property(e => e.Sotiendathanhtoan)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SOTIENDATHANHTOAN");
            entity.Property(e => e.Tongtienphaithanhtoa)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TONGTIENPHAITHANHTOA");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Donhang).WithMany(p => p.Congnocuakhachhangs)
                .HasForeignKey(d => d.Donhangid)
                .HasConstraintName("FK__CONGNOCUA__DONHA__5165187F");
        });

        modelBuilder.Entity<Congnovoinhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONGNOVO__3214EC274029AA8F");

            entity.ToTable("CONGNOVOINHACUNGCAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Hanthanhtoan)
                .HasColumnType("datetime")
                .HasColumnName("HANTHANHTOAN");
            entity.Property(e => e.Phieumuahangid).HasColumnName("PHIEUMUAHANGID");
            entity.Property(e => e.Sotienconno)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SOTIENCONNO");
            entity.Property(e => e.Sotiendathanhtoan)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SOTIENDATHANHTOAN");
            entity.Property(e => e.Tennhacungcap)
                .HasMaxLength(50)
                .HasColumnName("TENNHACUNGCAP");
            entity.Property(e => e.Tongtienphaithanhtoa)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TONGTIENPHAITHANHTOA");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Phieumuahang).WithMany(p => p.Congnovoinhacungcaps)
                .HasForeignKey(d => d.Phieumuahangid)
                .HasConstraintName("FK__CONGNOVOI__PHIEU__5EBF139D");
        });

        modelBuilder.Entity<Donhang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DONHANG__3214EC27728139FB");

            entity.ToTable("DONHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Conno)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CONNO");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Dathanhtoan)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DATHANHTOAN");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Diachigiaohang)
                .HasMaxLength(50)
                .HasColumnName("DIACHIGIAOHANG");
            entity.Property(e => e.Khachhangid).HasColumnName("KHACHHANGID");
            entity.Property(e => e.Ngaytaodon)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTAODON");
            entity.Property(e => e.Nhanvienid).HasColumnName("NHANVIENID");
            entity.Property(e => e.Thanhtien)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("THANHTIEN");
            entity.Property(e => e.Tinhtrangid).HasColumnName("TINHTRANGID");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Khachhang).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.Khachhangid)
                .HasConstraintName("FK__DONHANG__KHACHHA__4CA06362");

            entity.HasOne(d => d.Nhanvien).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.Nhanvienid)
                .HasConstraintName("FK__DONHANG__NHANVIE__4D94879B");

            entity.HasOne(d => d.Tinhtrang).WithMany(p => p.Donhangs)
                .HasForeignKey(d => d.Tinhtrangid)
                .HasConstraintName("FK__DONHANG__TINHTRA__4E88ABD4");
        });

        modelBuilder.Entity<Imagesanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMAGESAN__3214EC27DC243997");

            entity.ToTable("IMAGESANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Img)
                .HasColumnType("image")
                .HasColumnName("IMG");
            entity.Property(e => e.Sanphamid).HasColumnName("SANPHAMID");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Sanpham).WithMany(p => p.Imagesanphams)
                .HasForeignKey(d => d.Sanphamid)
                .HasConstraintName("FK__IMAGESANP__SANPH__44FF419A");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KHACHHAN__3214EC27E69DEF11");

            entity.ToTable("KHACHHANG");

            entity.HasIndex(e => e.Sodienthoai, "UQ__KHACHHAN__7670E299BCD7CBBB").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SODIENTHOAI");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<Kho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KHO__3214EC27D54C52E7");

            entity.ToTable("KHO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Tenkho)
                .HasMaxLength(50)
                .HasColumnName("TENKHO");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<Loaisanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOAISANP__3214EC27ED074F8D");

            entity.ToTable("LOAISANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Tenloaisanpham)
                .HasMaxLength(50)
                .HasColumnName("TENLOAISANPHAM");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHACUNGC__3214EC27C47808F8");

            entity.ToTable("NHACUNGCAP");

            entity.HasIndex(e => e.Sodienthoai, "UQ__NHACUNGC__7670E2998E50F7D8").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SODIENTHOAI");
            entity.Property(e => e.Tennhacungcap)
                .HasMaxLength(50)
                .HasColumnName("TENNHACUNGCAP");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHANVIEN__3214EC27D2F73E3E");

            entity.ToTable("NHANVIEN");

            entity.HasIndex(e => e.Sodienthoai, "UQ__NHANVIEN__7670E299CBCB98CF").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chucvu)
                .HasMaxLength(50)
                .HasColumnName("CHUCVU");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Matkhau)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SODIENTHOAI");
            entity.Property(e => e.Tennhanvien)
                .HasMaxLength(50)
                .HasColumnName("TENNHANVIEN");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<Phieumuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PHIEUMUA__3214EC27F4637B26");

            entity.ToTable("PHIEUMUAHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Ngaymuahang)
                .HasColumnType("datetime")
                .HasColumnName("NGAYMUAHANG");
            entity.Property(e => e.Nhacungcapid).HasColumnName("NHACUNGCAPID");
            entity.Property(e => e.Nhanvienid).HasColumnName("NHANVIENID");
            entity.Property(e => e.Tongtien)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TONGTIEN");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Nhacungcap).WithMany(p => p.Phieumuahangs)
                .HasForeignKey(d => d.Nhacungcapid)
                .HasConstraintName("FK__PHIEUMUAH__NHACU__5AEE82B9");

            entity.HasOne(d => d.Nhanvien).WithMany(p => p.Phieumuahangs)
                .HasForeignKey(d => d.Nhanvienid)
                .HasConstraintName("FK__PHIEUMUAH__NHANV__5BE2A6F2");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3214EC2791A3EB55");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baohanh)
                .HasMaxLength(50)
                .HasColumnName("BAOHANH");
            entity.Property(e => e.Chatlieu)
                .HasMaxLength(50)
                .HasColumnName("CHATLIEU");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Giaban)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GIABAN");
            entity.Property(e => e.Khoid).HasColumnName("KHOID");
            entity.Property(e => e.Loaisanphamid).HasColumnName("LOAISANPHAMID");
            entity.Property(e => e.Macsac)
                .HasMaxLength(50)
                .HasColumnName("MACSAC");
            entity.Property(e => e.Mota).HasColumnName("MOTA");
            entity.Property(e => e.Soluongton).HasColumnName("SOLUONGTON");
            entity.Property(e => e.Tensanpham)
                .HasMaxLength(50)
                .HasColumnName("TENSANPHAM");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

            entity.HasOne(d => d.Kho).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Khoid)
                .HasConstraintName("FK__SANPHAM__KHOID__4222D4EF");

            entity.HasOne(d => d.Loaisanpham).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Loaisanphamid)
                .HasConstraintName("FK__SANPHAM__LOAISAN__412EB0B6");
        });

        modelBuilder.Entity<Tinhtrang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TINHTRAN__3214EC272C8730EA");

            entity.ToTable("TINHTRANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Createdat)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDAT");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Deletedat)
                .HasColumnType("datetime")
                .HasColumnName("DELETEDAT");
            entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");
            entity.Property(e => e.Tentinhtrang)
                .HasMaxLength(50)
                .HasColumnName("TENTINHTRANG");
            entity.Property(e => e.Updatedat)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDAT");
            entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
