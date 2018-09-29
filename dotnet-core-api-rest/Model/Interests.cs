using System;
using System.ComponentModel.DataAnnotations;
using dotnetcoreapirest.Model.Base;

namespace dotnetcoreapirest.Model
{
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
