using Case_DataAccessLayer.Abstract;
using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_DataAccessLayer.Concrete.Repositories
{
    public class RoleRepository :GenericRepository<Role> ,IRoleRepositoryDal
    {
        private readonly CaseContext _context;

        public RoleRepository(CaseContext context):base(context)
        {
            _context = context;
        }

        public bool Delete(Expression<Func<Role, bool>> filter)
        {
            Role entity = _context.Set<Role>().SingleOrDefault(filter);
            _context.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public Role Get(Expression<Func<Role, bool>> filter)
        {
            return _context.Set<Role>().SingleOrDefault(filter);
        }

        public bool Insert(Role role)
        {
            _context.Set<Role>().Add(role);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Role> List()
        {
            return _context.Set<Role>().ToList();
        }

        public IEnumerable<Role> List(Expression<Func<Role, bool>> filter)
        {
            return _context.Set<Role>().Where(filter).ToList();
        }

        public bool Update(Role role)
        {
            _context.Set<Role>().Update(role);
            return _context.SaveChanges() > 0;
        }
    }
}
