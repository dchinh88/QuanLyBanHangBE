using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Domain.Common
{
    public class BaseEntities
    {
        
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }
        public int? deletedBy { get; set; }
        public int? updatedBy { get; set; }
        public int? createdBy { get; set; }
    }
}
