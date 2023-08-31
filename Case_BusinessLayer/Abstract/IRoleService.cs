using Case_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_BusinessLayer.Abstract
{
    public interface IRoleService:IGenericService<Role>
    {
        Role GetByID(int id);

    }
}
