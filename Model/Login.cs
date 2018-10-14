using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcoreapirest.Model
{
	[Table("login")]
    public class Login
    {
		public long? Id { get; set; }
		public string LoginUser { get; set; }
		public string AccessKey { get; set; }

    }
}
