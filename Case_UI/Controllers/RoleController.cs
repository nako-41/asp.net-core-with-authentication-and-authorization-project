using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Case_UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
       // private readonly RoleManager<AppRole> _roleManager;

        public IActionResult Index()
        {
            return View();
        }
    }
}
