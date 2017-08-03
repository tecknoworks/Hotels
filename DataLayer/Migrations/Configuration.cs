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
			  new Country { Id = 2, Name = "Hungary" },
			  new Country { Id = 3, Name = "Italy" },
			  new Country { Id = 4, Name = "Germany" },
			  new Country { Id = 5, Name = "France" }
			);

			context.Cities.AddOrUpdate(
			  p => p.Id,
			  new City { Id = 1, Name = "Cluj-Napoca", CountryId = 1 },
			  new City { Id = 2, Name = "Bucuresti", CountryId = 1 },
			  new City { Id = 3, Name = "Sibiu", CountryId = 1 },
			  new City { Id = 4, Name = "Budapest", CountryId = 2 },
			  new City { Id = 5, Name = "Rome", CountryId = 3 },
			  new City { Id = 6, Name = "Berlin", CountryId = 4 },
			  new City { Id = 7, Name = "Paris", CountryId = 5 }
			);

			context.NearbyPlaces.AddOrUpdate(
				p => p.Id,
				new Nearby { Id = 1, Name = "Marty", Location = "Iulius Mall", Type = NearbyType.Restaurant },
				new Nearby { Id = 2, Name = "Cluj Arena", Location = "Cluj Arena", Type = NearbyType.TouristAttraction },
				new Nearby { Id = 3, Name = "Olivo Cafe", Location = "Center", Type = NearbyType.CoffeeShop }

		   );

			context.UnityNearbyPlaces.AddOrUpdate(
				p => p.Id,
				new UnityNearby { Id = 1, NearbyId = 1 },
				new UnityNearby { Id = 2, NearbyId = 1 },
				new UnityNearby { Id = 3, NearbyId = 1 },
				new UnityNearby { Id = 4, NearbyId = 2 },
				new UnityNearby { Id = 5, NearbyId = 2 },
				new UnityNearby { Id = 6, NearbyId = 3 },
				new UnityNearby { Id = 7, NearbyId = 3 }
			);


			

			context.Reservations.AddOrUpdate(
				new Reservation { Id = 1, DateOfReservation =new DateTime( 2017,04,01), DateOfStart = new DateTime (2017,04,10),
				     DateOfEnd=new DateTime(2017,04,15),TotalPayment = 400,NumberOfPeople = 3,RoomReservationId = 1,UserId = 1}
				new Reservation { Id = 2, DateOfReservation =new DateTime( 2017,05,02), DateOfStart = new DateTime (2017,05,11),
				     DateOfEnd=new DateTime(2017,05,13),TotalPayment = 300,NumberOfPeople = 2,RoomReservationId = 2,UserId = 2},
				new Reservation{Id = 3,DateOfReservation = new DateTime(2017,06,07),DateOfStart = new DateTime(2017,06,20),
					DateOfEnd = new DateTime(2017,06,25),TotalPayment = 500,NumberOfPeople = 2,RoomReservationId = 3,UserId =1 }
			);








		}
	}
}
