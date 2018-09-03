
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Entities
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CityInfo;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // https://docs.microsoft.com/en-us/ef/core/modeling/relationships#fluent-api
            modelBuilder.Entity<City>().Ignore(c => c.PointsOfInterest);


            modelBuilder.ApplyConfiguration(new PointOfInterestConfiguration());

            //Data Seeding
            //https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
            modelBuilder.Entity<City>().HasData(new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "Great park in the middle",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){Id = 10,Name = "Point 10", Description = "Welcome to point 10"},
                        new PointOfInterest(){Id = 11,Name = "Point 11", Description = "Welcome to point 11"},
                        new PointOfInterest(){Id = 12,Name = "Point 12", Description = "Welcome to point 12"}
                    }
                },
                new City()
                {
                    Id = 2,
                    Name = "Boston",
                    Description = "Full of nerds",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){Id = 13,Name = "Point 13", Description = "Welcome to point 13"},
                        new PointOfInterest(){Id = 14,Name = "Point 14", Description = "Welcome to point 14"},
                        new PointOfInterest(){Id = 15,Name = "Point 15", Description = "Welcome to point 15"}
                    }
                },
                new City()
                {
                    Id = 3,
                    Name = "London",
                    Description = "Excellent tea",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){Id = 16,Name = "Point 16", Description = "Welcome to point 16"}
                    }
                });
        }
    }
}
