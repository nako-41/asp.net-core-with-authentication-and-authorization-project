using Case_BusinessLayer.Abstract;
using Case_DataAccessLayer.Abstract;
using Case_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Case_BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IRepositoryDal<T> _genericRepository;

        public GenericManager(IRepositoryDal<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(T t)
        {
            return _genericRepository.Insert(t);
        }



        public IEnumerable<T> GetList()
        {
            return _genericRepository.List();
        }

        public bool Update(T t)
        {
            return _genericRepository.Update(t);
        }

        bool IGenericService<T>.Delete(T t)
        {
            return _genericRepository.Delete(t);
        }
    }
}
