﻿using System;
using System.Collections.Generic;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Repository.Generic;

namespace dotnetcoreapirest.Business
{
	public interface IPersonBusiness : IRepository<Person>
    {
		List<Person> FindByName(string firstName, string lastName);
		List<Person> FindByCountry(string country);
    }
}
