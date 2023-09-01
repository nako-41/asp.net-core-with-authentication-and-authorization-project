using Case_BusinessLayer.Abstract;
using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _role;
        private readonly CaseContext _context;
        private readonly ILogger<RoleController> _logger;

        public RoleController(CaseContext context, IRoleService role, ILogger<RoleController> logger)
        {
            _context = context;
            _role = role;
            _logger = logger;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Role> GetMasterData(int id)
        {
            var rol = _context.Roles.Find(id);

            if (rol == null)
            {

              //  return NotFound("boyle bir role ID yok");
               _logger.LogInformation("boyle bir role ID yok");
            }
            if (_role.GetList() == null)
                    return NotFound();
                else
                {
                    try
                    {

                        Role role = _role.GetByID(id);
                        _logger.LogInformation("role geldi");
                        return role;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "role getirilemedi tekrar deneyiniz");
                        return BadRequest(ex.Message);
                    }
                }
           
            //return Ok("Role basarili geldi");
        }


        [HttpPost]
        public ActionResult<Role> SendMasterData(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            _logger.LogInformation("Basarili sekilde rol eklendi", role);
            return Ok();
        }

        [HttpDelete("{id}")]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteRole(int id)
        {
            var rol = _context.Roles.Find(id);

            if (rol == null)
            {
                return NotFound("boyle bir role ID yok");
               
            }

            _context.Roles.Remove(rol); 
            _context.SaveChanges(); 

        
            return Ok("Role basarili sekilde silindi");
        }


        [HttpPut]
        //[ValidateAntiForgeryToken]
        public IActionResult UpdateRole(Role role)
        {
            var rol = _context.Roles.Find(role.Id);

            if (rol == null)
            {
                return NotFound("boyle bir role ID yok");
            }


            _context.Update(role);
            _context.SaveChanges();
            return Ok("Role basarili sekilde guncellendi");
        }

    }
}
