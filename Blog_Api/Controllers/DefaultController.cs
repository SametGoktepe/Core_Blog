using Blog_Api.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult PersonList()
        {
            using var c = new Context();
            var values = c.Persons.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult PersonAdd(Person p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(int id)
        {
            using var c = new Context();
            var prsn = c.Persons.Find(id);
            if(prsn==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(prsn);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            using var c = new Context();
            var prsn = c.Persons.Find(id);
            if(prsn==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(prsn);
                c.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult UpdatePerson(Person person)
        {
            using var c = new Context();
            var prsn = c.Find<Person>(person.Id);
            if (prsn == null) return NotFound();
            else
            {
                prsn.Name = person.Name;
                c.Update(prsn);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
