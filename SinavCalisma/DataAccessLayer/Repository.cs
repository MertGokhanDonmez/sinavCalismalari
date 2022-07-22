using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {

        Context c = new Context();

        DbSet<T> _object;

        public Repository()
        {
            _object = c.Set<T>();
        }

        public int Delete(T entity)
        {
            _object.Remove(entity);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T entity)
        {
            _object.Add(entity);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update(T entity)
        {
            return c.SaveChanges();
        }
    }
}
