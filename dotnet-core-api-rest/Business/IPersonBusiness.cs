using System;
using System.Collections.Generic;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Repository.Generic;
using Tapioca.HATEOAS.Utils;

namespace dotnetcoreapirest.Business
{
	public interface IPersonBusiness : IRepository<Person>
    {
		List<Person> FindByName(string firstName, string lastName);
		List<Person> FindByCountry(string country);
		PagedSearchDTO<Person> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
    }
}
