using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanHang.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOTEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SODIENTHOAI = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__3214EC27E69DEF11", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KHO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENKHO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHO__3214EC27D54C52E7", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOAISANPHAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENLOAISANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAISANP__3214EC27ED074F8D", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NHACUNGCAP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNHACUNGCAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SODIENTHOAI = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHACUNGC__3214EC27C47808F8", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNHANVIEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAYSINH = table.Column<DateTime>(type: "datetime", nullable: true),
                    SODIENTHOAI = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MATKHAU = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CHUCVU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__3214EC27D2F73E3E", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TINHTRANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTINHTRANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TINHTRAN__3214EC272C8730EA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOAISANPHAMID = table.Column<int>(type: "int", nullable: true),
                    TENSANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GIABAN = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MACSAC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BAOHANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHOID = table.Column<int>(type: "int", nullable: true),
                    SOLUONGTON = table.Column<int>(type: "int", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__3214EC2791A3EB55", x => x.ID);
                    table.ForeignKey(
                        name: "FK__SANPHAM__KHOID__4222D4EF",
                        column: x => x.KHOID,
                        principalTable: "KHO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__SANPHAM__LOAISAN__412EB0B6",
                        column: x => x.LOAISANPHAMID,
                        principalTable: "LOAISANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AVATAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NHANVIENID = table.Column<int>(type: "int", nullable: true),
                    AVATAR = table.Column<byte[]>(type: "image", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AVATAR__3214EC27B1419861", x => x.ID);
                    table.ForeignKey(
                        name: "FK__AVATAR__NHANVIEN__3C69FB99",
                        column: x => x.NHANVIENID,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PHIEUMUAHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NHACUNGCAPID = table.Column<int>(type: "int", nullable: true),
                    NHANVIENID = table.Column<int>(type: "int", nullable: true),
                    NGAYMUAHANG = table.Column<DateTime>(type: "datetime", nullable: true),
                    TONGTIEN = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PHIEUMUA__3214EC27F4637B26", x => x.ID);
                    table.ForeignKey(
                        name: "FK__PHIEUMUAH__NHACU__5AEE82B9",
                        column: x => x.NHACUNGCAPID,
                        principalTable: "NHACUNGCAP",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__PHIEUMUAH__NHANV__5BE2A6F2",
                        column: x => x.NHANVIENID,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DONHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NGAYTAODON = table.Column<DateTime>(type: "datetime", nullable: true),
                    DIACHIGIAOHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KHACHHANGID = table.Column<int>(type: "int", nullable: true),
                    NHANVIENID = table.Column<int>(type: "int", nullable: true),
                    TINHTRANGID = table.Column<int>(type: "int", nullable: true),
                    THANHTIEN = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DATHANHTOAN = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CONNO = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DONHANG__3214EC27728139FB", x => x.ID);
                    table.ForeignKey(
                        name: "FK__DONHANG__KHACHHA__4CA06362",
                        column: x => x.KHACHHANGID,
                        principalTable: "KHACHHANG",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__DONHANG__NHANVIE__4D94879B",
                        column: x => x.NHANVIENID,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__DONHANG__TINHTRA__4E88ABD4",
                        column: x => x.TINHTRANGID,
                        principalTable: "TINHTRANG",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "IMAGESANPHAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SANPHAMID = table.Column<int>(type: "int", nullable: true),
                    IMG = table.Column<byte[]>(type: "image", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IMAGESAN__3214EC27DC243997", x => x.ID);
                    table.ForeignKey(
                        name: "FK__IMAGESANP__SANPH__44FF419A",
                        column: x => x.SANPHAMID,
                        principalTable: "SANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETPHIEUMUAHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PHIEUMUAHANGID = table.Column<int>(type: "int", nullable: true),
                    TENSANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    DONGIA = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHITIETP__3214EC272D89F422", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CHITIETPH__PHIEU__619B8048",
                        column: x => x.PHIEUMUAHANGID,
                        principalTable: "PHIEUMUAHANG",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONGNOVOINHACUNGCAP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PHIEUMUAHANGID = table.Column<int>(type: "int", nullable: true),
                    TENNHACUNGCAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TONGTIENPHAITHANHTOA = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    SOTIENDATHANHTOAN = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    SOTIENCONNO = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    HANTHANHTOAN = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONGNOVO__3214EC274029AA8F", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CONGNOVOI__PHIEU__5EBF139D",
                        column: x => x.PHIEUMUAHANGID,
                        principalTable: "PHIEUMUAHANG",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETDONHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DONHANGID = table.Column<int>(type: "int", nullable: true),
                    SANPHAMID = table.Column<int>(type: "int", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    DONGIA = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHITIETD__3214EC275F4960B2", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CHITIETDO__DONHA__5441852A",
                        column: x => x.DONHANGID,
                        principalTable: "DONHANG",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__CHITIETDO__SANPH__5535A963",
                        column: x => x.SANPHAMID,
                        principalTable: "SANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONGNOCUAKHACHHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DONHANGID = table.Column<int>(type: "int", nullable: true),
                    HOTEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TONGTIENPHAITHANHTOA = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    SOTIENDATHANHTOAN = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    SOTIENCONNO = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    HANTHANHTOAN = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    DELETEDBY = table.Column<int>(type: "int", nullable: true),
                    UPDATEDBY = table.Column<int>(type: "int", nullable: true),
                    CREATEDBY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CONGNOCU__3214EC27D50F88C9", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CONGNOCUA__DONHA__5165187F",
                        column: x => x.DONHANGID,
                        principalTable: "DONHANG",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AVATAR_NHANVIENID",
                table: "AVATAR",
                column: "NHANVIENID");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETDONHANG_DONHANGID",
                table: "CHITIETDONHANG",
                column: "DONHANGID");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETDONHANG_SANPHAMID",
                table: "CHITIETDONHANG",
                column: "SANPHAMID");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETPHIEUMUAHANG_PHIEUMUAHANGID",
                table: "CHITIETPHIEUMUAHANG",
                column: "PHIEUMUAHANGID");

            migrationBuilder.CreateIndex(
                name: "IX_CONGNOCUAKHACHHANG_DONHANGID",
                table: "CONGNOCUAKHACHHANG",
                column: "DONHANGID");

            migrationBuilder.CreateIndex(
                name: "IX_CONGNOVOINHACUNGCAP_PHIEUMUAHANGID",
                table: "CONGNOVOINHACUNGCAP",
                column: "PHIEUMUAHANGID");

            migrationBuilder.CreateIndex(
                name: "IX_DONHANG_KHACHHANGID",
                table: "DONHANG",
                column: "KHACHHANGID");

            migrationBuilder.CreateIndex(
                name: "IX_DONHANG_NHANVIENID",
                table: "DONHANG",
                column: "NHANVIENID");

            migrationBuilder.CreateIndex(
                name: "IX_DONHANG_TINHTRANGID",
                table: "DONHANG",
                column: "TINHTRANGID");

            migrationBuilder.CreateIndex(
                name: "IX_IMAGESANPHAM_SANPHAMID",
                table: "IMAGESANPHAM",
                column: "SANPHAMID");

            migrationBuilder.CreateIndex(
                name: "UQ__KHACHHAN__7670E299BCD7CBBB",
                table: "KHACHHANG",
                column: "SODIENTHOAI",
                unique: true,
                filter: "[SODIENTHOAI] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__NHACUNGC__7670E2998E50F7D8",
                table: "NHACUNGCAP",
                column: "SODIENTHOAI",
                unique: true,
                filter: "[SODIENTHOAI] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__NHANVIEN__7670E299CBCB98CF",
                table: "NHANVIEN",
                column: "SODIENTHOAI",
                unique: true,
                filter: "[SODIENTHOAI] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUMUAHANG_NHACUNGCAPID",
                table: "PHIEUMUAHANG",
                column: "NHACUNGCAPID");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUMUAHANG_NHANVIENID",
                table: "PHIEUMUAHANG",
                column: "NHANVIENID");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_KHOID",
                table: "SANPHAM",
                column: "KHOID");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_LOAISANPHAMID",
                table: "SANPHAM",
                column: "LOAISANPHAMID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AVATAR");

            migrationBuilder.DropTable(
                name: "CHITIETDONHANG");

            migrationBuilder.DropTable(
                name: "CHITIETPHIEUMUAHANG");

            migrationBuilder.DropTable(
                name: "CONGNOCUAKHACHHANG");

            migrationBuilder.DropTable(
                name: "CONGNOVOINHACUNGCAP");

            migrationBuilder.DropTable(
                name: "IMAGESANPHAM");

            migrationBuilder.DropTable(
                name: "DONHANG");

            migrationBuilder.DropTable(
                name: "PHIEUMUAHANG");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "TINHTRANG");

            migrationBuilder.DropTable(
                name: "NHACUNGCAP");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "KHO");

            migrationBuilder.DropTable(
                name: "LOAISANPHAM");
        }
    }
}
