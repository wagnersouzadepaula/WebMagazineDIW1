using System;
using System.ComponentModel.DataAnnotations;

namespace WebMagazine.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }

		public Product()
		{
		}
	}
}

