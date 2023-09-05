using Case_BusinessLayer.Abstract;
using Case_BusinessLayer.Concrete;
using Case_DataAccessLayer.Concrete.Repositories;
using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using Case_EntityLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Case_UI.Controllers
{
    //[Authorize]
    
    public class HomeController : Controller
    {

        //private readonly ISurveyAnswerService _surveyAnswerService;

        //public HomeController(ISurveyAnswerService surveyAnswerService)
        //{
        //    _surveyAnswerService = surveyAnswerService;
        //}



        public IActionResult Anasayfa()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        //anket detayları

        public IActionResult SurveyDetail()
        {
            return View();
        }

        //kullanıcı anket doldurma
        public IActionResult Survey()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SurveyAnswer(SurveyAnswer surveyAnswerViewModel)
        {
           // var surveyresult = new SurveyAnswer()
           // {
           //     Survey1 = surveyAnswerViewModel.Survey1,
           //     Survey2 = surveyAnswerViewModel.Survey2,
           //     Survey3 = surveyAnswerViewModel.Survey3,
           //     Survey4 = surveyAnswerViewModel.Survey4,
           //     Survey5 = surveyAnswerViewModel.Survey5,
           //     Age = surveyAnswerViewModel.Age,
           //     Gender= surveyAnswerViewModel.Gender,
           //     EducationInformation = surveyAnswerViewModel.EducationInformation,
           //     City = surveyAnswerViewModel.City,
           //     District = surveyAnswerViewModel.District
           // };
           //bool result= _surveyAnswerService.Add(surveyresult);



            return View();
        }
    }
}
