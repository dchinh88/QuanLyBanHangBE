using QuanLyBanHang.Application.Common;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface IKhachhangService
    {
        List<KhachhangDTO> GetAllKhachhang_NoQuery();
        PageListResult<KhachhangDTO> GetAllKhachhang(KhachhangQuery query);
        KhachhangDTO GetKhachhangById(int id);
        bool AddKhachhang(KhachhangDTO dto);
        bool UpdateKhachhang(KhachhangDTO dto);
        bool DeleteKhachhang(int id);

        KhachhangDTO GetKhachhangByPhone(string phone);
    }
}
