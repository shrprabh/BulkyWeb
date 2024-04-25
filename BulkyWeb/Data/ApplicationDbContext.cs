	using System;
	using BulkyWeb.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Migrations;

	namespace BulkyWeb.Data
	{
		public class ApplicationDbContext:DbContext
		{

			public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
			{

			}

			public DbSet<Category> Categories { get; set; }
			protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
				modelBuilder.Entity<Category>().HasData(
					new Category { CategoryId = 101, Name = "Action", DisplayOrder = 1 },
					new Category { CategoryId = 102, Name = "SciFi", DisplayOrder = 2 },
					new Category { CategoryId = 103, Name = "History", DisplayOrder = 3 }
					);
			}

		}
	}

