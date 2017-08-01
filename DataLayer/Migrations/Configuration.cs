namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hotels.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Hotels.Models.ApplicationDbContext";
        }

        protected override void Seed(Hotels.Models.ApplicationDbContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			context.Countries.AddOrUpdate(
			  p => p.Id,
			  new Country { Id = 1, Name = "Romania" },
			  new Country { Id = 2, Name = "Hungary" }
			);

			context.Cities.AddOrUpdate(
			  p => p.Id,
			  new City { Id = 1, Name = "Cluj-Napoca", CountryId = 1 }
			);
		}
	}
}
