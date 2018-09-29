using System;
using System.Collections.Generic;

namespace dotnetcoreapirest.Model
{
	public class Freelancer : Person
    {
		public string About { get; set; }

		public string Professional { get; set; }

		public List<Skills> Skills { get; set; }
    }
}
