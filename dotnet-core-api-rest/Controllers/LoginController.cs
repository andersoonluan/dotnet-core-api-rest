using System;
using dotnetcoreapirest.Business;
using dotnetcoreapirest.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcoreapirest.Controllers
{
	[ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
	public class LoginController : Controller
    {
		private ILoginBusiness _loginBusiness;

        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody]Login login)
        {
            if (login == null) return BadRequest();
            return _loginBusiness.FindByLogin(login);
        }

    }
}
