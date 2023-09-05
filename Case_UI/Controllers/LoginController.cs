using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Case_UI.Controllers
{

    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
