using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Domain.Repositories;
using QuanLyBanHang.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Infrastructure.Repositories
{
    public class Repositories<T> : IRepositories<T> where T : class, new()
    {
        private readonly QlkinhdoanhContext context;
        DbSet<T> entities;
        public Repositories(QlkinhdoanhContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }

        public bool Add(T entity)
        {
            if(!entities.Any(e => e == entity))
            {
                entities.Add(entity);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = entities.Find(id);
            if(entity == null)
            {
                return false;
            }
            entities.Remove(entity);
            context.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetEntity(int id)
        {
            var entity = entities.Find(id);
            if(entity != null)
            {
                return entity;
            }
            return null;
        }

        public bool Update(T entity)
        {
            if(!entities.Any(e => e == entity))
            {
                return false;
            }
            context.Entry(entity).State = EntityState.Modified;
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
    }
}
