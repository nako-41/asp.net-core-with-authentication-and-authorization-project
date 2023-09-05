using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        IEnumerable<T> GetList();
        bool Add(T t);
        bool Update(T t);
        bool Delete(T t);   
    }
}
