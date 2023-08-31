using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T>
    {
        IEnumerable<T> List();
        bool Insert(T p);
        T Get(Expression<Func<T, bool>> filter);
        bool Update(T p);
        bool Delete(Expression<Func<T, bool>> filter);
        IEnumerable<T> List(Expression<Func<T, bool>> filter);


    }
}
