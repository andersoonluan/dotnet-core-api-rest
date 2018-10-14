using System;
using System.ComponentModel.DataAnnotations;
using dotnetcoreapirest.Model.Base;

namespace dotnetcoreapirest.Model
{
	public class Skills : BaseEntity
    {
		[Required]
        [StringLength(100)]
		public string Name { get; set; }

		public DateTime CreateOn { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
		public Skills()
		{
			this.CreateOn = DateTime.Now;
		}
    }
}
