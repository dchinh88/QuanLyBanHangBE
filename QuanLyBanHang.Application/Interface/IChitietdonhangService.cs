using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface IChitietdonhangService
    {
        List<ChitietdonhangDTO> GetAllChitietdonhang();
        ChitietdonhangDTO GetChitietdonhangById(int id);
        bool AddChitietdonhang(ChitietdonhangDTO dto);
        bool UpdateChitietdonhang(ChitietdonhangDTO dto);
        bool DeleteChitietdonhang(int id);
    }
}
