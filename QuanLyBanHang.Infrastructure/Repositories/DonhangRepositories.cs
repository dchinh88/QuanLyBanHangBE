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
    public class DonhangRepositories : Repositories<Donhang>, IDonhangRepositories
    {
        public DonhangRepositories(QlkinhdoanhContext context) : base(context) { }
    }
}
