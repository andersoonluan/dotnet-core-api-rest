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
	public class SkillsController : ControllerBase
    {
		//Declaração do serviço usado
        private ISkillsBusiness _skillsBusiness;

        /* Injeção de uma instancia de IBookBusiness ao criar
        uma instancia de BookController */
		public SkillsController(ISkillsBusiness skillsController)
        {
			_skillsBusiness = skillsController;
        }

		//Mapeia as requisições GET para http://localhost:{porta}/api/skills/v1/
        //Get sem parâmetros para o FindAll --> Busca Todos
        [HttpGet]
        public IActionResult Get()
        {
			return Ok(_skillsBusiness.FindAll());
        }

		//Mapeia as requisições GET para http://localhost:{porta}/api/skills/v1/{id}
        //recebendo um ID como no Path da requisição
        //Get com parâmetros para o FindById --> Busca Por ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
			var book = _skillsBusiness.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

		//Mapeia as requisições POST para http://localhost:{porta}/api/skills/v1/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        [HttpPost]
		[Authorize("Bearer")]
        public IActionResult Post([FromBody]Skills skill)
        {
            if (skill == null) return BadRequest();
			return new ObjectResult(_skillsBusiness.Create(skill));
        }

		//Mapeia as requisições PUT para http://localhost:{porta}/api/skills/v1/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        [HttpPut]
		[Authorize("Bearer")]
		public IActionResult Put([FromBody]Skills skill)
        {
            if (skill == null) return BadRequest();
			var updateSkill = _skillsBusiness.Update(skill);
			if (updateSkill == null) return BadRequest();
			return new ObjectResult(updateSkill);
        }


        //Mapeia as requisições DELETE para http://localhost:{porta}/api/skills/v1/{id}
        //recebendo um ID como no Path da requisição
        [HttpDelete("{id}")]
		[Authorize("Bearer")]
        public IActionResult Delete(int id)
        {
			_skillsBusiness.Delete(id);
            return NoContent();
        }
    }
}
