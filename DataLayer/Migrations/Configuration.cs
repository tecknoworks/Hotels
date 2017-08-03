namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.IO;
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


            //context.RoomReservations.AddOrUpdate(
            //  p => p.Id,
            //new RoomReservation { Id = 1, DateOfStart = new DateTime(2017,08,01), RoomId = 3 }
            //new RoomReservation { Id = 2, DateOfStart = DateTime.ParseExact("06/06/2008 18:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), DateOfEnd = DateTime.ParseExact("09/06/2008 18:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), RoomId = 1 },
            //new RoomReservation { Id = 3, DateOfStart = DateTime.ParseExact("20/06/2008 14:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), DateOfEnd = DateTime.ParseExact("24/06/2008 14:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), RoomId = 2 }\
            //);

            //context.Reservations.AddOrUpdate(
            //    new Reservation
            //    {
            //        Id = 1,
            //        DateOfReservation = new DateTime(2017, 04, 01),
            //        DateOfStart = new DateTime(2017, 04, 10),
            //        DateOfEnd = new DateTime(2017, 04, 15),
            //        TotalPayment = 400,
            //        NumberOfPeople = 3,
            //        RoomReservationId = 1,
            //        UserId = 1
            //    },
            //new Reservation
            //{
            //    Id = 2,
            //    DateOfReservation = new DateTime(2017, 05, 02),
            //    DateOfStart = new DateTime(2017, 05, 11),
            //    DateOfEnd = new DateTime(2017, 05, 13),
            //    TotalPayment = 300,
            //    NumberOfPeople = 2,
            //    RoomReservationId = 2,
            //    UserId = 2
            //},
            //    new Reservation
            //    {
            //        Id = 3,
            //        DateOfReservation = new DateTime(2017, 06, 07),
            //        DateOfStart = new DateTime(2017, 06, 20),
            //        DateOfEnd = new DateTime(2017, 06, 25),
            //        TotalPayment = 500,
            //        NumberOfPeople = 2,
            //        RoomReservationId = 3,
            //        UserId = 1
            //    }
            //);
            context.Acomodations.AddOrUpdate(
               p => p.Id,
               new Acomodation
               {
                   Id = 1,
                   Type = AcomodationType.Hotel,
                   Address = "Str.Nicoara Moise nr.10",
                   Name = "Belagio",
                   NumberOfStars = 3,
                   Picture = Helper.ImageToByteArray(Image.FromFile(@"C:\Work\Images\hotel1.jpg")),
                   Description = "Nice hotel with a great view",
                   PhoneNumber = "07433256963",
                   WebSite = "www.",
                   CityId = 1
               });


            context.Facilities.AddOrUpdate(
                p => p.Id,
                new Facility { Id = 1, Description = "Close to the beach" },
                new Facility { Id = 2, Description = "Close to supermarkets" },
                new Facility { Id = 3, Description = "In a quaiet area" }
               );
            context.Reviews.AddOrUpdate(
                p => p.Id,
                new Review { Id = 1, Date= new DateTime(2017, 08, 01), Description="I liked everything",UserId=1,AcomodationId=1}
               );
          
            context.UnityFacilities.AddOrUpdate(
                p=>p.Id,
                new UnityFacility { Id = 1, FacilityId = 1, AcomodationId = 1 }
            //    new UnityFacility { Id = 2, FacilityId = 2, AcomodationId = 1 }
            //    //new UnityFacility { Id = 3, FacilityId = 2, AcomodationId = 2 }
                );


        }  
    }
}
