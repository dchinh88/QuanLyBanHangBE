using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public interface INhanvienService
    {
        List<NhanvienDTO> GetAllNhanvien_NoQuery();
        PageListResult<NhanvienDTO> GetAllNhanvien(NhanvienQuery? query);
        NhanvienDTO GetNhanvienById(int id);
        bool AddNhanvien(NhanvienDTO dto);
        bool UpdateNhanvien(NhanvienDTO dto);
        bool DeleteNhanvien(int id);
        bool SoftDelete(NhanvienDTO dto);
       
    }
}
