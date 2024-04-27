using System;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			
		}
	}
}

