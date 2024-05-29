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
    public interface ISanPhamService
    {
        List<SanphamDTO> GetAllSanpham_NoQuery();
        PageListResult<SanphamDTO> GetAllSanpham(SanphamQuery query);
        SanphamDTO GetSanphamById(int id);
        bool AddSanpham(SanphamDTO dto);
        bool UpdateSanpham(SanphamDTO dto);
        bool DeleteSanpham(int id);


        List<SanphamDTO> GetSanphamByName(string name);
        List<SanphamDTO> GetSanphamByIdLoaisanpham(int id);
        List<SanphamDTO> GetSanphamByIdKho(int id);
        List<SanphamDTO> SortTangDan(List<SanphamDTO> sanphams);
        List<SanphamDTO> SortGiamDan(List<SanphamDTO> sanphams);
    }
}
