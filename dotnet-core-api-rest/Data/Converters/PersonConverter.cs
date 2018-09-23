using System;
using System.Collections.Generic;
using System.Linq;
using dotnetcoreapirest.Data.Converter;
using dotnetcoreapirest.Data.VO;
using dotnetcoreapirest.Model;

namespace dotnetcoreapirest.Data.Converters
{
	public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
	{
		/// <summary>
        /// Parse the specified Origem.
        /// </summary>
        /// <returns>The parse.</returns>
        /// <param name="Origem">Origem.</param>
		public Person Parse(PersonVO Origem)
		{
			if (Origem == null)
				return new Person();

			return new Person
			{
				Id = Origem.Id,
				Name = Origem.Name,
				LastName = Origem.LastName,
				Country = Origem.Country,
				City = Origem.City,
				Address = Origem.Endereco,
				Gender = Origem.Gender,
				Age = Origem.Age,
				Birthday = Origem.Birthday,
				Email = Origem.Email,
				CreateOn = Origem.CreateOn
			};
		}

        /// <summary>
        /// Parse the specified Origem.
        /// </summary>
        /// <returns>The parse.</returns>
        /// <param name="Origem">Origem.</param>
		public PersonVO Parse(Person Origem)
		{
			if (Origem == null)
				return new PersonVO();

			return new PersonVO
            {
                Id = Origem.Id,
                Name = Origem.Name,
                LastName = Origem.LastName,
                Country = Origem.Country,
                City = Origem.City,
				Endereco = Origem.Address,
                Gender = Origem.Gender,
                Age = Origem.Age,
                Birthday = Origem.Birthday,
                Email = Origem.Email,
                CreateOn = Origem.CreateOn
            };
		}

        /// <summary>
        /// Parses the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="Origem">Origem.</param>
		public List<Person> ParseList(List<PersonVO> Origem)
		{
			if (Origem == null)
                return new List<Person>();

			return Origem.Select(item => Parse(item)).ToList();
		}

        /// <summary>
        /// Parses the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="Origem">Origem.</param>
		public List<PersonVO> ParseList(List<Person> Origem)
		{
			if (Origem == null)
                return new List<PersonVO>();

			return Origem.Select(item => Parse(item)).ToList();
		}
	}
}
