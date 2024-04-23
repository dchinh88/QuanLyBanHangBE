using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Common
{
    public class PageListResult<T> where T : class
    {
        public List<T> items { get; set; }
        public int totalItems { get; set; }
    }
}
