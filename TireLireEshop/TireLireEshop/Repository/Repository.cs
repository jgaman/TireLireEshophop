using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireLireEshop.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private dbtirelireshopContext _context;
        
        public Repository(dbtirelireshopContext context)
        {
            _context = context;
        }
        
        public T DeleteItem(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetItem(T item)
        {
            throw new NotImplementedException();
        }

        public T InsertItem(T item)
        {
            throw new NotImplementedException();
        }

        public T UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
