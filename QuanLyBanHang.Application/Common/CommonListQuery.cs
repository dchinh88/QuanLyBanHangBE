using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Common
{
    public class CommonListQuery
    {
        public int page { get; set; }
        public int limit { get; set; }
        public string? orderBy { get; set; }
        public string? keyWord { get; set; }
        public CommonListQuery() 
        {
            page = 1;
            limit = 10;
            orderBy = "CreateAt";
            keyWord = string.Empty;
        }
    }
}
