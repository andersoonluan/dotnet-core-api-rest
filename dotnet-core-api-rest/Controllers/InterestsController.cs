using System;
using dotnetcoreapirest.Business;
using dotnetcoreapirest.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcoreapirest.Controllers
{
	[ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
	public class InterestsController : ControllerBase
    {
		//Declaração do serviço usado
		private IInterestsBusiness _interestsBusiness;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:dotnetcoreapirest.Controllers.InterestsController"/> class.
        /// </summary>
        /// <param name="interestsBusiness">Interests business.</param>
		public InterestsController(IInterestsBusiness interestsBusiness)
        {
			_interestsBusiness = interestsBusiness;
        }

        /// <summary>
        /// Get this instance.
        /// </summary>
        /// <returns>The get.</returns>
        [HttpGet]
        public IActionResult Get()
        {
			return Ok(_interestsBusiness.FindAll());
        }

        /// <summary>
        /// Get the specified id.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="id">Identifier.</param>
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
			var interests = _interestsBusiness.FindById(id);
			if (interests == null) return NotFound();
			return Ok(interests);
        }

        /// <summary>
        /// Post the specified interests.
        /// </summary>
        /// <returns>The post.</returns>
        /// <param name="interests">Interests.</param>
        [HttpPost]
        [Authorize("Bearer")]
		public IActionResult Post([FromBody]Interests interests)
        {
			if (interests == null) return BadRequest();
			return new ObjectResult(_interestsBusiness.Create(interests));
        }

        /// <summary>
        /// Put the specified interests.
        /// </summary>
        /// <returns>The put.</returns>
        /// <param name="interests">Interests.</param>
        [HttpPut]
        [Authorize("Bearer")]
		public IActionResult Put([FromBody]Interests interests)
        {
			if (interests == null) return BadRequest();
			var interestsUpdate = _interestsBusiness.Update(interests);
			if (interestsUpdate == null) return BadRequest();
			return new ObjectResult(interestsUpdate);
        }


        /// <summary>
        /// Delete the specified id.
        /// </summary>
        /// <returns>The delete.</returns>
        /// <param name="id">Identifier.</param>
        [HttpDelete("{id}")]
        [Authorize("Bearer")]
        public IActionResult Delete(int id)
        {
			_interestsBusiness.Delete(id);
            return NoContent();
        }
    }
}
