﻿using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface ICongnovoinhacungcapService
    {
        List<CongnovoinhacungcapDTO> GetAllCongnovoinhacungcap();
        CongnovoinhacungcapDTO GetCongnovoinhacungcapById(int id);
        bool AddCongnovoinhacungcap(CongnovoinhacungcapDTO dto);
        bool UpdateCongnovoinhacungcap(CongnovoinhacungcapDTO dto);
        bool DeleteCongnovoinhacungcap(int id);
    }
}
