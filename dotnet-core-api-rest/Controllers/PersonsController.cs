using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcoreapirest.Business;
using dotnetcoreapirest.Model;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <returns>The by name.</returns>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        [HttpGet("freelancer")]
		public ActionResult GetByName([FromQuery] string firstName, string lastName)
        {
			return new OkObjectResult(_personBusiness.FindByName(firstName, lastName));
        }
       
        /// <summary>
        /// Gets the by country.
        /// </summary>
        /// <returns>The by country.</returns>
        /// <param name="country">Country.</param>
		[HttpGet("find-country")]
        public ActionResult GetByCountry([FromQuery] string country)
        {
			return new OkObjectResult(_personBusiness.FindByCountry(country));
        }

        // GET api/values/5
        [HttpGet("{id}")]
		[Authorize("Bearer")]
        public ActionResult Get(int id)
        {
			var person = _personBusiness.FindById(id);

			if (person == null) 
				return NotFound();

			return Ok(person);
        }

        // POST api/values
        [HttpPost]
		[Authorize("Bearer")]
		public ActionResult Post([FromBody] Person person)
        {         
            if (person == null)
				return BadRequest();

			return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut]
		[Authorize("Bearer")]
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
		[Authorize("Bearer")]
		public ActionResult Delete(int id)
        {
			_personBusiness.Delete(id);
			return NotFound();
        }
    }
}
