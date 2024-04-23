using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface ILoaisanphamService
    {
        List<LoaisanphamDTO> GetAllLoaisanpham();
        LoaisanphamDTO GetLoaisanphamById(int id);
        bool AddLoaisanpham(LoaisanphamDTO dto);
        bool UpdateLoaisanpham(LoaisanphamDTO dto);
        bool DeleteLoaisanpham(int id);
    }
}
