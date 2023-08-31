using Case_DataAccessLayer.Context;
using Case_EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MembershipSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly CaseContext _context;

        public PersonController(CaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Role> Add(Role role)
        {
            _context.Add(role);
            _context.SaveChanges();
            return role;
        }
        [HttpGet]
        public ActionResult<List<Role>> List()
        {
            return _context.Roles.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Role> GetRole(Role role)
        {
            return _context.Roles.FirstOrDefault(role);
        }
        [HttpPut("{id}")]
        public ActionResult<Role> Edit(Role person, int id)
        {
            if (person.Id != id)
            {
                return BadRequest();
            }
            _context.Roles.Update(person);
            _context.SaveChanges();
            return person;

        }
        [HttpDelete("{id}")]
        public ActionResult<Role> Delete(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Role returning = _context.Roles.FirstOrDefault(x => x.Id == id);
            _context.Roles.Remove(returning);
            _context.SaveChanges();
            return Ok();
        }

    }
}