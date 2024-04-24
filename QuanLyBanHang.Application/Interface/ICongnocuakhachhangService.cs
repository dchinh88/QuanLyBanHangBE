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
    public interface ICongnocuakhachhangService
    {
        List<CongnocuakhachhangDTO> GetAllCongnocuakhachhang_NoQuery();
        PageListResult<CongnocuakhachhangDTO> GetAllCongnocuakhachhang(CongnocuakhachhangQuery query);
        CongnocuakhachhangDTO GetCongnocuakhachhangById(int id);
        bool AddCongnocuakhachhang(CongnocuakhachhangDTO dto);
        bool UpdateCongnocuakhachhang(CongnocuakhachhangDTO dto);
        bool DeleteCongnocuakhachhang(int id);
    }
}
