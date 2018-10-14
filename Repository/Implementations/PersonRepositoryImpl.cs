using System;
using System.Collections.Generic;
using System.Linq;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Model.Context;
using dotnetcoreapirest.Repository.Generic;

namespace dotnetcoreapirest.Repository.Implementations
{
	public class PersonRepositoryImpl : GenericRepository<Person>, IPersonRepository
    {

		public PersonRepositoryImpl(MySQLContext context) : base(context){ }

        /// <summary>
        /// Finds the name of the by.
        /// </summary>
        /// <returns>The by name.</returns>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
		public List<Person> FindByName(string firstName, string lastName)
		{
			if(!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
			{
				return _context.Persons.Where(p => p.Name.Contains(firstName) && p.LastName.Contains(lastName)).ToList();
			}
			else if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
			{
				return _context.Persons.Where(p => p.LastName.Contains(lastName)).ToList();
			}
			else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
				return _context.Persons.Where(p => p.Name.Contains(firstName)).ToList();
            }
			else
			{
				return _context.Persons.ToList();
			}
		}

        /// <summary>
        /// Finds the by country.
        /// </summary>
        /// <returns>The by country.</returns>
        /// <param name="country">Country.</param>
		public List<Person> FindByCountry(string country)
		{
			return _context.Persons.Where(p => p.Country.Contains(country)).ToList();
		}
  
	}
}
