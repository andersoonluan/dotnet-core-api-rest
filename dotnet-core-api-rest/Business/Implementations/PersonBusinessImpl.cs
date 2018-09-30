using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Model.Context;
using dotnetcoreapirest.Repository;
using dotnetcoreapirest.Repository.Generic;
using Tapioca.HATEOAS.Utils;

namespace dotnetcoreapirest.Business.Implementations
{
	public class PersonBusinessImpl : IPersonBusiness
	{
		private IPersonRepository _repository;
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:dotnetcoreapirest.Business.Implementations.PersonBusinessImpl"/> class.
        /// </summary>
        /// <param name="repository">Repository.</param>
		public PersonBusinessImpl(IPersonRepository repository)
		{
			_repository = repository;
		}

        /// <summary>
        /// Create Method Person
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="person">Person.</param>
		public Person Create(Person person)
		{
			return _repository.Create(person);
		}

        /// <summary>
        /// Delete the specified id.
        /// </summary>
        /// <param name="id">Identifier.</param>
		public void Delete(long id)
		{
			_repository.Delete(id);
		}

        /// <summary>
        /// Exists the specified id.
        /// </summary>
        /// <returns>The exists.</returns>
        /// <param name="id">Identifier.</param>
		public bool Exists(long? id)
		{
			return _repository.Exists(id);
		}

		/// <summary>
		/// Finds all.
		/// </summary>
		/// <returns>The all.</returns>
		public List<Person> FindAll()
		{
			return _repository.FindAll();
		}

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <returns>The by identifier.</returns>
        /// <param name="id">Identifier.</param>
		public Person FindById(long id)
		{
			return _repository.FindById(id);

		}

        /// <summary>
        /// Finds the name of the by.
        /// </summary>
        /// <returns>The by name.</returns>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
		public List<Person> FindByName(string firstName, string lastName)
		{
			return _repository.FindByName(firstName, lastName);
		}

        /// <summary>
        /// Finds the by country.
        /// </summary>
        /// <returns>The by country.</returns>
        /// <param name="country">Country.</param>
		public List<Person> FindByCountry(string country)
        {
			return _repository.FindByCountry(country);
        }

		/// <summary>
		/// Update the specified person.
		/// </summary>
		/// <returns>The update.</returns>
		/// <param name="person">Person.</param>
		public Person Update(Person person)
		{
			return _repository.Update(person);
		}
        
        /// <summary>
        /// Finds the with paged search.
        /// </summary>
        /// <returns>The with paged search.</returns>
        /// <param name="name">Name.</param>
        /// <param name="sortDirection">Sort direction.</param>
        /// <param name="pageSize">Page size.</param>
        /// <param name="page">Page.</param>
		public PagedSearchDTO<Person> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
		{
			page = page > 0 ? page - 1 : 0;
			string query = @"select * from persons p where 1 = 1 ";
			if(!string.IsNullOrEmpty(name))
			{
				query += $" and p.name like '%{name}%' ";
			}
			query += $" order by p.name {sortDirection} limit {pageSize} offset {page}";                 
            

			string countQuery = @"select count(*) from persons p where 1 = 1 ";
            if (!string.IsNullOrEmpty(name))
            {
				countQuery += $" and p.name like '%{name}%' ";
            }


			var persons = _repository.FindWithPagedSearch(query);
			int totalResults = _repository.GetCount(countQuery);

			return new PagedSearchDTO<Person>
			{
				CurrentPage = page + 1,
				List = persons,
				PageSize = pageSize,
				SortDirections = sortDirection,
				TotalResults = totalResults
			};
		}


        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns>The count.</returns>
        /// <param name="query">Query.</param>
		public int GetCount(string query)
		{
			return _repository.GetCount(query);
		}

        /// <summary>
        /// Finds the with paged search.
        /// </summary>
        /// <returns>The with paged search.</returns>
        /// <param name="query">Query.</param>
		public List<Person> FindWithPagedSearch(string query)
		{
			return _repository.FindWithPagedSearch(query);
		}
	}



}
