using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T> where T : class
    {
        IEnumerable<T> List();
        bool Insert(T p);
        T Get(int id);
        bool Update(T p);
        bool Delete(T p);
        IEnumerable<T> List(Expression<Func<T, bool>> filter);


    }
}
