using Case_BusinessLayer.Abstract;
using Case_BusinessLayer.Concrete;
using Case_DataAccessLayer.Concrete.Repositories;
using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using Case_EntityLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Case_UI.Controllers
{

    [AllowAnonymous]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly CaseContext _context;

        private readonly ISurveyAnswerService _surveyAnswerService;

        public HomeController(CaseContext context, ISurveyAnswerService surveyAnswerService)
        {
            _context = context;
            _surveyAnswerService = surveyAnswerService;
        }

        public IActionResult HomePage()
        {
    

            return View();
        }

        public IActionResult Index()
        {
            List<SurveyAnswer> result = _surveyAnswerService.GetList().ToList();

           

            var jsonData = JsonConvert.SerializeObject(result); // JSON verisini hazırlayın
           
            ViewBag.ChartData = jsonData;


            return View(result);
        }

        //anket detayları

        public IActionResult SurveyDetail()
        {
            return View();
        }

        //kullanıcı anket doldurma

        public IActionResult Survey(int userId)
        {
          
            ViewBag.user =userId;
     

            return View();

            
        }


        [HttpPost]
        public async Task<IActionResult> Survey([Bind("Survey1, Survey2, Survey3, Survey4, Survey5, Age, Gender, EducationInformation, City, District,userId")] SurveyAnswer surveyAnswerViewModel)
        {
            

            var surveyresult = new SurveyAnswer()
            {
               
                Survey1 = surveyAnswerViewModel.Survey1,
                Survey2 = surveyAnswerViewModel.Survey2,
                Survey3 = surveyAnswerViewModel.Survey3,
                Survey4 = surveyAnswerViewModel.Survey4,
                Survey5 = surveyAnswerViewModel.Survey5,
                Age = surveyAnswerViewModel.Age,
                Gender = surveyAnswerViewModel.Gender,
                educationInformations = surveyAnswerViewModel.educationInformations,
                City = surveyAnswerViewModel.City,
                District = surveyAnswerViewModel.District,
                userId= surveyAnswerViewModel.userId

            };

            surveyresult.City.ToUpper();
            surveyresult.District.ToUpper();
            surveyresult.Gender.ToString().ToUpper();

            var result = _context.Add(surveyresult);

           

            _context.SaveChanges();


            return View();
        }
    }
}
