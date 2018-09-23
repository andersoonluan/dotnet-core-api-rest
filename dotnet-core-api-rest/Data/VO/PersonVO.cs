using System;
namespace dotnetcoreapirest.Data.VO
{
    public class PersonVO
    {
		public long? Id { get; set; }
		public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Endereco { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public DateTime CreateOn { get; set; }

    }
}
