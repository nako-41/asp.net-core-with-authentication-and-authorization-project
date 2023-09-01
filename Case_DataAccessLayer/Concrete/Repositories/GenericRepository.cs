using Case_DataAccessLayer.Abstract;
using Case_DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepositoryDal<T> where T : class
    {
        private readonly CaseContext _context;

        public GenericRepository(CaseContext context)
        {
            _context = context;
        }

    
        public bool Delete(T p)
        {
            T entity = _context.Set<T>().SingleOrDefault(p);
            _context.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Insert(T p)
        {
            _context.Set<T>().Add(p);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public  IEnumerable<T> List(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public bool Update(T p)
        {
            _context.Set<T>().Update(p);
            return _context.SaveChanges() > 0;
        }
    }
}
