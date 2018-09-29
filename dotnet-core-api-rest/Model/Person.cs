using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using dotnetcoreapirest.Model.Base;

namespace dotnetcoreapirest.Model
{
	public class Person : BaseEntity
    {
		[Required]
        [StringLength(100)]
		public string Name { get; set; }

		[Required]
        [StringLength(100)]
		public string LastName { get; set; }

		[Required]
        [StringLength(30)]
		public string Country { get; set; }

		[Required]
        [StringLength(70)]
		public string City { get; set; }

		public string Address { get; set; }

		[Required]
        [StringLength(100)]
		public string Gender { get; set; }

		public int Age { get; set; }

		[Required]
        [StringLength(100)]
		public DateTime Birthday { get; set; }

		[Required]
        [StringLength(100)]
		public string Email { get; set; }

		public DateTime CreateOn { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:dotnetcoreapirest.Model.Person"/> class.
        /// </summary>
		public Person()
		{
			this.CreateOn = DateTime.Now;
		}
    }
}
