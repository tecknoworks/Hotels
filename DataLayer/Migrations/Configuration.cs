namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hotels.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Hotels.Models.ApplicationDbContext";
        }

        // convert image to byte array
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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

			context.NearbyPlaces.AddOrUpdate(
				p => p.Id,
				new Nearby { Id = 1, Name = "Marty",Location = "Iulius Mall",Type=NearbyType.Restaurant}
		   );
            context.Acomodations.AddOrUpdate(
                p => p.Id,
                new Acomodation
                {
                    Id = 1,
                    Type = AcomodationType.Hotel,
                    Address = "Str.Nicoara Moise nr.10",
                    Name = "Belagio",
                    NumberOfStars = 3,
                    Picture = imageToByteArray(Image.FromFile(@"C:\Work\Images\hotel1.jpg")),
                    Description = "Nice hotel with a great view",
                    PhoneNumber = "07433256963",
                    WebSite = "www.",
                    CityId = 1
                });


            context.Facilities.AddOrUpdate(
                p => p.Id,
                new Facility { Id = 1, Description = "Close to the beach" },
                new Facility { Id = 2, Description="Close to supermarkets"},
                new Facility { Id = 3, Description = "In a quaiet area" }
               );
            //context.Reviews.AddOrUpdate(
            //    p => p.Id,
            //    new Review { Id = 1, Date= new DateTime(2017, 08, 01), Description="I liked everything",UserId=1,AcomodationId=1}
            //   );
            //context.RoomReservations.AddOrUpdate(
            //    p => p.Id,
            //    new RoomReservation { Id = 1, DateOfStart = new DateTime(2017,08,01), RoomId = 3 }
            //    //new RoomReservation { Id = 2, DateOfStart = DateTime.ParseExact("06/06/2008 18:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), DateOfEnd = DateTime.ParseExact("09/06/2008 18:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), RoomId = 1 },
            //    //new RoomReservation { Id = 3, DateOfStart = DateTime.ParseExact("20/06/2008 14:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), DateOfEnd = DateTime.ParseExact("24/06/2008 14:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture), RoomId = 2 }\
            //    );
            //context.UnityFacilities.AddOrUpdate(
            //    p=>p.Id,
            //    new UnityFacility { Id = 1, FacilityId = 1, AcomodationId = 1 },
            //    new UnityFacility { Id = 2, FacilityId = 2, AcomodationId = 1 }
            //    //new UnityFacility { Id = 3, FacilityId = 2, AcomodationId = 2 }
            //    );
		}
	}
}
