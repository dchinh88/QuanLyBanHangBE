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
    public interface IDonhangService
    {
        List<DonhangDTO> GetAllDonhang_NoQuery();
        PageListResult<DonhangDTO> GetAllDonhang(DonhangQuery query);
        DonhangDTO GetDonhangById(int id);
        bool AddDonhang(DonhangDTO dto);
        bool UpdateDonhang(DonhangDTO dto);
        bool DeleteDonhang(int id);
    }
}
