using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Repositories;
using QuanLyBanHang.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Infrastructure.Repositories
{
    public class KhachhangRepositories : Repositories<Khachhang>, IKhachhangRepositories
    {
        public KhachhangRepositories(QlkinhdoanhContext context) : base(context) { }
    }
}
