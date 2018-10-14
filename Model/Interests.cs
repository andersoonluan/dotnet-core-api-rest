using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetcoreapirest.Model.Base;

namespace dotnetcoreapirest.Model
{
	[Table("interests")]
	public class Interests : BaseEntity
    {
		[Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime CreateOn { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
		public Interests()
        {
            this.CreateOn = DateTime.Now;
        }
    }
}
