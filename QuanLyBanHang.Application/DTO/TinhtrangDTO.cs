﻿using QuanLyBanHang.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.DTO
{
    public class TinhtrangDTO : BaseEntities
    {
        public int Id { get; set; }

        public string? Tentinhtrang { get; set; }
    }
}
