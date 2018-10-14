using System;
using System.Collections.Generic;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Repository.Generic;

namespace dotnetcoreapirest.Repository
{
	public interface IPersonRepository : IRepository<Person>
    {
		List<Person> FindByName(string firstName, string lastName);
		List<Person> FindByCountry(string country);
    }
}
