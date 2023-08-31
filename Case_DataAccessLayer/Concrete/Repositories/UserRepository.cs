using Case_DataAccessLayer.Abstract;
using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_DataAccessLayer.Concrete.Repositories
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
        private readonly CaseContext _context;

        public UserRepository(CaseContext context):base(context)
        {
            _context = context;
        }
        public bool Delete(Expression<Func<User, bool>> filter)
        {
            User entity = _context.Set<User>().SingleOrDefault(filter);
            _context.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _context.Set<User>().SingleOrDefault(filter);
        }

        public bool Insert(User role)
        {
            _context.Set<User>().Add(role);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<User> List()
        {
            return _context.Set<User>().ToList();
        }

        public IEnumerable<User> List(Expression<Func<User, bool>> filter)
        {
            return _context.Set<User>().Where(filter).ToList();
        }

        public bool Update(User role)
        {
            _context.Set<User>().Update(role);
            return _context.SaveChanges() > 0;
        }
    }
}
