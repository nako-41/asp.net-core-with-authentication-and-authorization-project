using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
