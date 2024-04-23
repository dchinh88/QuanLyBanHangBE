﻿using QuanLyBanHang.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Interface
{
    public interface ISanPhamService
    {
        List<SanphamDTO> GetAllSanpham();
        SanphamDTO GetSanphamById(int id);
        bool AddSanpham(SanphamDTO dto);
        bool UpdateSanpham(SanphamDTO dto);
        bool DeleteSanpham(int id);
    }
}