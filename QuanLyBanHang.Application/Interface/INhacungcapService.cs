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
    public interface INhacungcapService
    {
        List<NhacungcapDTO> GetAllNhacungcap_NoQuery();
        PageListResult<NhacungcapDTO> GetAllNhacungcap(NhacungcapQuery query);
        NhacungcapDTO GetNhacungcapById(int id);
        bool AddNhacungcap(NhacungcapDTO dto);
        bool UpdateNhacungcap(NhacungcapDTO dto);
        bool DeleteNhacungcap(int id);
    }
}
