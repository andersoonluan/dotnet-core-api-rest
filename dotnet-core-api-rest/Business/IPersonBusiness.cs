using System;
using System.Collections.Generic;
using dotnetcoreapirest.Model;

namespace dotnetcoreapirest.Business
{
    public interface IPersonBusiness
    {
		Person Create(Person person);
		Person FindById(long id);
		List<Person> FindAll();
		Person Update(Person person);
		void Delete(long id);

    }
}
