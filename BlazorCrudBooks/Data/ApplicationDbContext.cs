using System;
using BlazorCrudBooks.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudBooks.Data
{
	public class ApplicationDbContext : DbContext

	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
		}

		//Colocar cada modelo
		public DbSet<Libro> Libro { get; set; }
	}
}

