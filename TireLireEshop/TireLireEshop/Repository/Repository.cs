using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.EntityFrameworkCore;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace TireLireEshop.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private dbtirelireshopContext _context;
        
        public Repository(dbtirelireshopContext context)
        {
            _context = context;
        }
        
        public T DeleteItem(int id)
        {
            try
            {
                T user = _context.Set<T>().Find(id);
                _context.Set<T>().Remove(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetItem(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T InsertItem(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;    
            
        }

        public T Save()
        {
            throw new NotImplementedException();
        }

        public T UpdateItem(T item)
        {
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;

        }

        public object UpdateItem()
        {
            throw new NotImplementedException();
        }
    }
}
