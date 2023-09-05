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
    public class SurveyAnswerManager : GenericManager<SurveyAnswer>, ISurveyAnswerService
    {
        private readonly ISurveyAnswerRepositoryDal AnswerRepositoryDal;

        public SurveyAnswerManager(IRepositoryDal<SurveyAnswer> genericRepository, ISurveyAnswerRepositoryDal answerRepositoryDal) : base(genericRepository)
        {
            AnswerRepositoryDal = answerRepositoryDal;
        }


    }
}
