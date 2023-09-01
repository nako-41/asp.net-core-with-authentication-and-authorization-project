using Case_BusinessLayer.Abstract;
using Case_DataAccessLayer.Abstract;
using Case_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_BusinessLayer.Concrete
{
    public class RoleManager : GenericManager<Role>, IRoleService
    {
        private readonly IRoleRepositoryDal _roleRepository;

        public RoleManager(IRoleRepositoryDal roleRepository) : base(roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public Role GetByID(int id)
        {
            return _roleRepository.Get(id);
        }
    }
}
