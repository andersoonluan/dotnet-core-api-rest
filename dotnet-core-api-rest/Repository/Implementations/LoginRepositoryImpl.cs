using System;
using System.Linq;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Model.Context;

namespace dotnetcoreapirest.Repository.Implementations
{
	public class LoginRepositoryImpl : ILoginRepository
    {
		private readonly MySQLContext _context;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:dotnetcoreapirest.Repository.Implementations.UserRepositoryImpl"/> class.
        /// </summary>
        /// <param name="context">Context.</param>
        public LoginRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Finds the by login.
        /// </summary>
        /// <returns>The by login.</returns>
        /// <param name="login">Login.</param>
        public Login FindByLogin(string login)
        {
			return _context.Login.SingleOrDefault(u => u.LoginUser.Equals(login));
        }


	}
}
