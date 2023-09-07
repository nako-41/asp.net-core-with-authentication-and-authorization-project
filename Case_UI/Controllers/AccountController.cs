using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using Case_EntityLayer.Helpers;
using Case_EntityLayer.Identity;
using Case_EntityLayer.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Web;

namespace Case_UI.Controllers
{

    [AllowAnonymous]
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly CaseContext _caseContext;

        public AccountController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, CaseContext caseContext)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._signInManager = signInManager;
            this._caseContext = caseContext;

        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (User.Identity.Name != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel login)
        {

            if (ModelState.IsValid)
            {
                var info = _caseContext.Users.FirstOrDefault(x => x.UserName == login.UserName && x.PasswordHash == login.Password);

                //var user = await _userManager.FindByNameAsync(login.UserName);


                if (info != null)
                {
                    ViewBag.Id = info.Id;
                    //HttpContext.Session.SetString("username", info.UserName);
                    var claims = new List<Claim>
                      {
                      new Claim(ClaimTypes.Name, login.UserName)
                      };
                    // await _userManager.AddToRoleAsync(user, "admin");
                    //var useridentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var useridentity=new ClaimsIdentity(claims,"login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                    //await HttpContext.SignInAsync(principal);

                    //AuthenticationProperties properties = new AuthenticationProperties
                    //{
                    //    AllowRefresh = true,
                    //    IsPersistent = info.rolId == 1,
                    //};


                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(useridentity),properties);




                    if (info.rolId == 1) // admin
                        return RedirectToAction("Index", "Home");
                    else if (info.rolId == 2)
                    {
                        SurveyAnswer answer = new SurveyAnswer();
                        answer.userId = info.rolId;
                        //ViewBag.user = info.rolId;
                        // SurveyAnswer survey=new SurveyAnswer();
                        // survey.userId = ViewBag.user;

                        return RedirectToAction("Survey", "Home", new { userId = answer.userId });

                    } // user
                        
                    else if (info.rolId== 3) // employee
                        return RedirectToAction("Survey", "Home");
                }

            }




            //var user = await _userManager.FindByNameAsync(login.UserName);


            //if (user != null)
            //{
            //    var result = await _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, true);
            //    if (result.Succeeded)
            //        return RedirectToAction("Index", "Home");
            //}

            return View();

        }
        public IActionResult Register()
        {
            if (User.Identity.Name != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser()
                {
                    Name = register.Name,
                    SurName = register.Surname,
                    UserName = register.Username,
                    Email = register.Email,
                    PasswordHash = register.Password
                };
                if (register.Username == user.UserName && register.Email == user.Email)
                {
                    ViewBag.message = "böyle bir kullanıcı sistemde kayıtlı";
                    return View(register);
                }
                else
                {
                    var result = await _userManager.CreateAsync(user, register.Password);
                    // await _userManager.AddToRoleAsync(user, "Users");
                    if (result.Succeeded)
                        return RedirectToAction("Login");
                }
            }

                return View(register);
          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }



    }
}
