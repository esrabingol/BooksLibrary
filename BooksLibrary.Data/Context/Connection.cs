using BooksLibrary.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.Context
{
	public class Connection: DbContext
	{
		public DbSet<Books> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseSqlServer(@"Server=LAPTOP-IPQTP7GR;Database=BooksLibrary;Integrated Security=true;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		
			modelBuilder.Entity<Books>().HasKey(b => b.BooksId);

			base.OnModelCreating(modelBuilder);
		}
	}
}
