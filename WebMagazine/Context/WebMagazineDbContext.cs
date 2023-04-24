using System;
using Microsoft.EntityFrameworkCore;
using WebMagazine.Models;

namespace WebMagazine.Context
{
	public class WebMagazineDbContext : DbContext
	{
		public WebMagazineDbContext(DbContextOptions<WebMagazineDbContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
	}
}

