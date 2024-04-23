using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface ITinhtrangService
    {
        List<TinhtrangDTO> GetAllTinhtrang();
        TinhtrangDTO GetTinhtrangById(int id);
        bool AddTinhtrang(TinhtrangDTO dto);
        bool UpdateTinhtrang(TinhtrangDTO dto);
        bool DeleteTinhtrang(int id);
    }
}
