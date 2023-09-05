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
    public class SurveyAnswerRepository : GenericRepository<SurveyAnswer>, ISurveyAnswerRepositoryDal
    {

        private readonly CaseContext _context;

        public SurveyAnswerRepository(CaseContext context) : base(context)
        {
          
        }
        public bool Delete(Expression<Func<Survey, bool>> filter)
        {
            Survey entity = _context.Set<Survey>().SingleOrDefault(filter);
            _context.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public Survey Get(Expression<Func<Survey, bool>> filter)
        {
            return _context.Set<Survey>().SingleOrDefault(filter);
        }

        public bool Insert(Survey role)
        {
            _context.Set<Survey>().Add(role);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Survey> List()
        {
            return _context.Set<Survey>().ToList();
        }

        public IEnumerable<Survey> List(Expression<Func<Survey, bool>> filter)
        {
            return _context.Set<Survey>().Where(filter).ToList();
        }

        public bool Update(Survey role)
        {
            _context.Set<Survey>().Update(role);
            return _context.SaveChanges() > 0;
        }
    }
}
