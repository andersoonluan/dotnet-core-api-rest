using System;
using dotnetcoreapirest.Model;

namespace dotnetcoreapirest.Repository
{
    public interface ILoginRepository
    {
		Login FindByLogin(string login);
    }
}
