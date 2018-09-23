using System;
using System.Collections.Generic;
using System.Threading;
using dotnetcoreapirest.Model;

namespace dotnetcoreapirest.Services.Implementations
{
	public class PersonServiceImpl : IPersonService
	{
		private volatile int count;

		public Person Create(Person person)
		{
			return person;
		}

		public void Delete(long id)
		{
			throw new NotImplementedException();
		}

		public List<Person> FindAll()
		{
			List<Person> persons = new List<Person>();
			for (int i = 0; i < 8; i++)
			{
				Person person = MockPerson(i);
				persons.Add(person);
			}
			return persons;
		}

		public Person FindById(long id)
		{
			Person person = MockPerson(Convert.ToInt32(id));
			return person; 

		}

		public Person Update(Person person)
		{
			return person;
		}

		private Person MockPerson(int i) => new Person
		{
			Id = IncrementAndGet(),
			Name = "Person Name " + i,
			Country = "Brazil",
			City = "Porto Alegre",
			Address = Guid.NewGuid().ToString(),
			Gender = "Male",
			Age = 24,
			Birthday = DateTime.Parse("08/03/1994"),
			Email = "andersoonluan@gmail.com"
		};

		private long IncrementAndGet()
		{
			return Interlocked.Increment(ref count);
		}
	}



}
