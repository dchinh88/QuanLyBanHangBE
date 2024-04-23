using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface IChitietphieumuahangService
    {
        List<ChitietphieumuahangDTO> GetAllChitietphieumuahang();
        ChitietphieumuahangDTO GetChitietphieumuahangById(int id);
        bool AddChitietphieumuahang(ChitietphieumuahangDTO dto);
        bool UpdateChitietphieumuahang(ChitietphieumuahangDTO dto);
        bool DeleteChitietphieumuahang(int id);
    }
}
