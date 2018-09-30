using System;
using System.Collections.Generic;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Repository.Generic;

namespace dotnetcoreapirest.Business.Implementations
{
	public class BookBusinessImpl : IBookBusiness
    {
		private IRepository<Book> _repository;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:dotnetcoreapirest.Business.Implementations.PersonBusinessImpl"/> class.
        /// </summary>
        /// <param name="repository">Repository.</param>
		public BookBusinessImpl(IRepository<Book> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Create the specified book.
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="book">Book.</param>
		public Book Create(Book book)
        {

            return _repository.Create(book);
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
		public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <returns>The by identifier.</returns>
        /// <param name="id">Identifier.</param>
		public Book FindById(long id)
        {
            return _repository.FindById(id);

        }

		public List<Book> FindWithPagedSearch(string query)
		{
			throw new NotImplementedException();
		}

		public int GetCount(string query)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Update the specified book.
		/// </summary>
		/// <returns>The update.</returns>
		/// <param name="book">Book.</param>
		public Book Update(Book book)
        {
            return _repository.Update(book);
        }
        
	}
}
