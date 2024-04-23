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
    public class PhieumuahangRepositories : Repositories<Phieumuahang>, IPhieumuahangRepositories
    {
        public PhieumuahangRepositories(QlkinhdoanhContext context) : base(context) { }
    }
}
