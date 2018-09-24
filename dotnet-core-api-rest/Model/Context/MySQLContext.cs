using System;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoreapirest.Model.Context
{
	public class MySQLContext : DbContext
    {
		public MySQLContext(){}

		public MySQLContext(DbContextOptions<MySQLContext> options) : base (options)
		{
			
		}

		public DbSet<Person> Persons { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Login> Login { get; set; }


    }
}
