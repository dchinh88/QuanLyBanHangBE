using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Domain.Repositories
{
    public interface IRepositories<T> where T : class, new()
    {
        List<T> GetAll();
        T GetEntity(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);

        T GetByString(int name);
    }
}
