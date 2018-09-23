using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Model.Context;
using dotnetcoreapirest.Repository;

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
        /// Update the specified person.
        /// </summary>
        /// <returns>The update.</returns>
        /// <param name="person">Person.</param>
		public Person Update(Person person)
		{
			return _repository.Update(person);
		}

        
	}



}
