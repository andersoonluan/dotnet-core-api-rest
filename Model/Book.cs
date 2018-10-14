using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetcoreapirest.Model.Base;

namespace dotnetcoreapirest.Model
{
	[Table("books")]
	public class Book : BaseEntity
    {
		public string Title { get; set; }
		public string Author { get; set; }
		public decimal Price { get; set; }
		public DateTime LaunchDate { get; set; }

    }
}
