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
    public interface IPhieumuahangService
    {
        List<PhieumuahangDTO> GetAllPhieumuahang_NoQuery();
        PageListResult<PhieumuahangDTO> GetAllPhieumuahang(PhieumuahangQuery query);
        PhieumuahangDTO GetPhieumuahangById(int id);
        bool AddPhieumuahang(PhieumuahangDTO dto);
        bool UpdatePhieumuahang(PhieumuahangDTO dto);
        bool DeletePhieumuahang(int id);
    }
}
