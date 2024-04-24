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
    public interface IKhoService
    {
        List<KhoDTO> GetAllKho_NoQuery();
        PageListResult<KhoDTO> GetAllKho(KhoQuery query);
        KhoDTO GetKhoById(int id);
        bool AddKho(KhoDTO dto);
        bool UpdateKho(KhoDTO dto);
        bool DeleteKho(int id);
    }
}
