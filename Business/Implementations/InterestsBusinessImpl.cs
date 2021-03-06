﻿using System;
using System.Collections.Generic;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Repository.Generic;

namespace dotnetcoreapirest.Business.Implementations
{
	public class InterestsBusinessImpl : IInterestsBusiness
	{
		private IRepository<Interests> _repository;
       
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:dotnetcoreapirest.Business.Implementations.InterestsBusinessImpl"/> class.
        /// </summary>
        /// <param name="repository">Repository.</param>
		public InterestsBusinessImpl(IRepository<Interests> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Create the specified item.
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="item">Item.</param>
		public Interests Create(Interests item)
		{
			return _repository.Create(item);
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
		public List<Interests> FindAll()
		{
			return _repository.FindAll();
		}

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <returns>The by identifier.</returns>
        /// <param name="id">Identifier.</param>
		public Interests FindById(long id)
		{
			return _repository.FindById(id);
		}

		public List<Interests> FindWithPagedSearch(string query)
		{
			throw new NotImplementedException();
		}

		public int GetCount(string query)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Update the specified item.
		/// </summary>
		/// <returns>The update.</returns>
		/// <param name="item">Item.</param>
		public Interests Update(Interests item)
		{
			return _repository.Update(item);
		}
	}
}
