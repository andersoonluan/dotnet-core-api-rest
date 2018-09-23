using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_api_rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
		private IPersonService _personService;

		public PersonsController(IPersonService personService)
		{
			_personService = personService;	
		}

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
			return Ok(_personService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
			var person = _personService.FindById(id);

			if (person == null) 
				return NotFound();

			return Ok(person);
        }

        // POST api/values
        [HttpPost]
		public ActionResult Post([FromBody] Person person)
        {         
            if (person == null)
				return BadRequest();

			return new ObjectResult(_personService.Create(person));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
		public ActionResult Put([FromBody] Person person)
        {
			if (person == null)
                return BadRequest();

			return new ObjectResult(_personService.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
		public ActionResult Delete(int id)
        {
			_personService.Delete(id);
			return NoContent();
        }
    }
}
