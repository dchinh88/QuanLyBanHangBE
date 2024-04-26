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
    public interface ILoaisanphamService
    {
        List<LoaisanphamDTO> GetAllLoaisanpham_NoQuery();
        PageListResult<LoaisanphamDTO> GetAllLoaisanpham(LoaisanphamQuery query);
        LoaisanphamDTO GetLoaisanphamById(int id);
        bool AddLoaisanpham(LoaisanphamDTO dto);
        bool UpdateLoaisanpham(LoaisanphamDTO dto);
        bool DeleteLoaisanpham(int id);
    }
}
