using Case_BusinessLayer.Abstract;
using Case_BusinessLayer.Concrete;
using Case_DataAccessLayer.Abstract;
using Case_DataAccessLayer.Concrete.Repositories;
using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using Case_EntityLayer.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
//{
//    options.Cookie.Name = "asp.net_core";
//    options.LoginPath = "/Home/Index";
//    options.AccessDeniedPath = "/Account/Login";
//});

builder.Services.AddDbContext<CaseContext>();
builder.Services.AddScoped<IRepositoryDal<SurveyAnswer>, SurveyAnswerRepository>();
builder.Services.AddScoped<ISurveyAnswerRepositoryDal, SurveyAnswerRepository>();
builder.Services.AddScoped<ISurveyAnswerService, SurveyAnswerManager>();


//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//                   .RequireAuthenticatedUser()
//                   .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));

//});


//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("RequireLoggedIn", policy =>
//    {
//        policy.RequireAuthenticatedUser();
//    });

//    options.AddPolicy("RequireAdminRole", policy =>
//    {
//        policy.RequireRole("admin"); // "Admin" rol�ne sahip kullan�c�lar eri�ebilir
//    });

//});


//Identity
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//kitilendi�inde
    options.Lockout.MaxFailedAccessAttempts = 3;//kilitleme s�resi ne kadar yanl�� girdi�i 
    options.Password.RequireNonAlphanumeric = false;//noktalama gibi �eyleri kald�rmak 
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
}).AddEntityFrameworkStores<CaseContext>()
.AddDefaultTokenProviders().AddRoles<AppRole>();//her kullsn�c� i�in s�re 


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";//Giri� yap�lmad�ysa autr ile ilgili 
    options.AccessDeniedPath = "/";//Yetkisi yoksa
    options.Cookie = new CookieBuilder
    {
        Name = "AspN" +
        "587etCoreIdentityExampleCookie",
        HttpOnly = false,
        SameSite = SameSiteMode.Lax,
        SecurePolicy = CookieSecurePolicy.Always//Https �zerinden
    };
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
});


//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("RequireLoggedIn", policy =>
//    {
//        policy.RequireAuthenticatedUser();
//    });

//    options.AddPolicy("RequireAdminRole", policy =>
//    {
//        policy.RequireRole("admin"); // "Admin" rol�ne sahip kullan�c�lar eri�ebilir
//    });

//});

////Add Session
//builder.Services.AddSession();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();



app.UseRouting();

//app.UseSession();

app.UseAuthentication();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
