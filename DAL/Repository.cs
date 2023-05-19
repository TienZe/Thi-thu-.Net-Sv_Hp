using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.DAL
{
    public class Repository<T> where T : class
    {
        public virtual IEnumerable<T> GetAll()
        {
            var context = new AppDbContext();
            return context.Set<T>().ToList();
        }

        public virtual T? GetById(object id)
        {
            var context = new AppDbContext();
            return context.Set<T>().Find(id);
        }

        public virtual void Add(T obj)
        {
            var context = new AppDbContext();
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public virtual void Update(T obj)
        {
            var context = new AppDbContext();
            context.Set<T>().Update(obj);
            context.SaveChanges();
        }
        public virtual void Delete(object id)
        {
            var context = new AppDbContext();
            var table = context.Set<T>();
            T? obj = table.Find(id);
            if (obj != null)
            {
                table.Remove(obj);
                context.SaveChanges();
            }
        }
    }
}
