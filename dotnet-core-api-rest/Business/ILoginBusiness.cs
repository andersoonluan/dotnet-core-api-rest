using System;
using dotnetcoreapirest.Model;

namespace dotnetcoreapirest.Business
{
    public interface ILoginBusiness
    {
		object FindByLogin(Login login);
    }
}
