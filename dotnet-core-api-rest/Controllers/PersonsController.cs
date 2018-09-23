using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcoreapirest.Business;
using dotnetcoreapirest.Model;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_api_rest.Controllers
{
	[ApiVersion("1")]
	[Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
		private IPersonBusiness _personBusiness;

		public PersonsController(IPersonBusiness personBusiness)
		{
			_personBusiness = personBusiness;	
		}

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
			return Ok(_personBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
			var person = _personBusiness.FindById(id);

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

			return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut]
		public ActionResult Put([FromBody] Person person)
        {
			if (person == null)
                return BadRequest();
			var resultUpdate = _personBusiness.Update(person);

			if (resultUpdate == null)
				return NoContent();
			else            
				return new ObjectResult(resultUpdate);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
		public ActionResult Delete(int id)
        {
			_personBusiness.Delete(id);
			return NotFound();
        }
    }
}
