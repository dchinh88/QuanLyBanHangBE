using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface IDonhangService
    {
        List<DonhangDTO> GetAllDonhang();
        DonhangDTO GetDonhangById(int id);
        bool AddDonhang(DonhangDTO dto);
        bool UpdateDonhang(DonhangDTO dto);
        bool DeleteDonhang(int id);
    }
}
