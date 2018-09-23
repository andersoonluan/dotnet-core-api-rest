using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Model.Context;

namespace dotnetcoreapirest.Services.Implementations
{
	public class PersonServiceImpl : IPersonService
	{
		private MySQLContext _context;
        
        // Default constructor
		public PersonServiceImpl(MySQLContext context)
		{
			_context = context;
		}

		public Person Create(Person person)
		{
			try
			{
				_context.Add(person);
				_context.SaveChanges();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return person;
		}

		public void Delete(long id)
		{
			var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
				if(result != null)
				{
					_context.Persons.Remove(result);
					_context.SaveChanges();
				}
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
		}

		public List<Person> FindAll()
		{
			return _context.Persons.ToList();
		}

		public Person FindById(long id)
		{
			return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

		}

		public Person Update(Person person)
		{
			if (!Exists(person.Id)) return new Person();

			var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

			try
            {
				_context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
		}

		private bool Exists(long? id)
		{
			return _context.Persons.Any(p => p.Id.Equals(id));
		}
	}



}
