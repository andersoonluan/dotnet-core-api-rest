using System;
using System.Collections.Generic;
using System.Linq;
using dotnetcoreapirest.Model.Base;
using dotnetcoreapirest.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoreapirest.Repository.Generic
{
	public class GenericRepository<T> : IRepository<T> where T : BaseEntity
	{
		protected MySQLContext _context;
		private DbSet<T> dataset;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:dotnetcoreapirest.Repository.Generic.GenericRepository`1"/> class.
        /// </summary>
        /// <param name="context">Context.</param>
		public GenericRepository(MySQLContext context)
        {
            _context = context;
			dataset = _context.Set<T>();
        }

        /// <summary>
        /// Create the specified item.
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="item">Item.</param>
		public T Create(T item)
		{
			try
            {
				dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
		}

        /// <summary>
        /// Delete the specified id.
        /// </summary>
        /// <param name="id">Identifier.</param>
		public void Delete(long id)
		{
			var result = dataset.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
                if (result != null)
                {
					dataset.Remove(result);
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

        /// <summary>
        /// Exists the specified id.
        /// </summary>
        /// <returns>The exists.</returns>
        /// <param name="id">Identifier.</param>
		public bool Exists(long? id)
		{
			return dataset.Any(p => p.Id.Equals(id));
		}

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <returns>The all.</returns>
		public List<T> FindAll()
		{
			return dataset.ToList();
		}

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <returns>The by identifier.</returns>
        /// <param name="id">Identifier.</param>
		public T FindById(long id)
		{
			return dataset.SingleOrDefault(p => p.Id.Equals(id));
		}

        /// <summary>
        /// Update the specified item.
        /// </summary>
        /// <returns>The update.</returns>
        /// <param name="item">Item.</param>
		public T Update(T item)
		{
			if (!Exists(item.Id)) return null;

			var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

            try
            {
				_context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
		}
	}
}
