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
            context.Countries.AddOrUpdate(
              p => p.Id,
              new Country { Id = 1, Name = "Romania",Lat= "44.439663" ,Lng= "26.096306" },
              new Country { Id = 2, Name = "Hungary",Lat= "47.497912",Lng= "19.04023499999994" },
              new Country { Id = 3, Name = "Italy",Lat= "41.9027835",Lng= "12.496365500000024"},
              new Country { Id = 4, Name = "Germany",Lat= "52.520008",Lng= "13.404954 " },
              new Country { Id = 5, Name = "France",Lat= "48.864716",Lng= "2.349014" }
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
            
            context.AcomodationNearbyPlaces.AddOrUpdate(
                p => p.Id,
                new AcomodationNearby { Id = 1, NearbyId = 1,AcomodationId=1 },
                new AcomodationNearby { Id = 2, NearbyId = 1 ,AcomodationId=2},
                new AcomodationNearby { Id = 3, NearbyId = 1 ,AcomodationId=1},
                new AcomodationNearby { Id = 4, NearbyId = 2 ,AcomodationId=2},
                new AcomodationNearby { Id = 5, NearbyId = 2 ,AcomodationId=3},
                new AcomodationNearby { Id = 6, NearbyId = 3 ,AcomodationId=1},
                new AcomodationNearby { Id = 7, NearbyId = 3 ,AcomodationId=3}
            );
            context.Rooms.AddOrUpdate(
                p => p.Id,
                new Room{ Id = 1, Type = RoomType.Single, Price = 23, NumberOfAdults=1, NumberOfChildren=0,RoomPhoto="roomS1.jpg", Description="Nice view",NumberOfRoomsAvailable=4,AcomodationId=1},
                new Room{ Id = 2, Type = RoomType.Double, Price = 50, NumberOfAdults = 2, NumberOfChildren = 0, RoomPhoto ="roomD1.jpg", Description = "Large room", NumberOfRoomsAvailable = 3,AcomodationId=2 },
                new Room{ Id = 3, Type = RoomType.Triple, Price = 70, NumberOfAdults = 2, NumberOfChildren = 1, RoomPhoto="roomT1.jpg", Description = "2 bathrooms", NumberOfRoomsAvailable = 5,AcomodationId=2 }
                );
            
            context.RoomReservations.AddOrUpdate(
              p => p.Id,
            new RoomReservation { Id = 1, DateOfStart = new DateTime(2017, 04, 10), DateOfEnd = new DateTime(2017, 04, 15), RoomId = 3,ReservationId=1 },
            new RoomReservation { Id = 2, DateOfStart = new DateTime(2017, 05, 11), DateOfEnd = new DateTime(2017, 05, 13),RoomId=1,ReservationId=2 },
            new RoomReservation { Id = 3,DateOfStart = new DateTime(2017, 06, 20), DateOfEnd = new DateTime(2017, 06, 25),RoomId=2,ReservationId=3}
            );
            
            context.Reservations.AddOrUpdate(
                new Reservation
                {
                    Id = 1,
                    DateOfReservation = new DateTime(2017, 04, 01),
                    DateOfStart = new DateTime(2017, 04, 10),
                    DateOfEnd = new DateTime(2017, 04, 15),
                    TotalPayment = 400,
                    NumberOfPeople = 3,
                    RoomReservationId = 1,
                    UserId = 1
                },
            new Reservation
            {
                Id = 2,
                DateOfReservation = new DateTime(2017, 05, 02),
                DateOfStart = new DateTime(2017, 05, 11),
                DateOfEnd = new DateTime(2017, 05, 13),
                TotalPayment = 300,
                NumberOfPeople = 2,
                RoomReservationId = 2,
                UserId = 2
            },
                new Reservation
                {
                    Id = 3,
                    DateOfReservation = new DateTime(2017, 06, 07),
                    DateOfStart = new DateTime(2017, 06, 20),
                    DateOfEnd = new DateTime(2017, 06, 25),
                    TotalPayment = 500,
                    NumberOfPeople = 2,
                    RoomReservationId = 3,
                    UserId = 1
                }
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
                   AcomodationPhoto = "hotel1.jpg",
                   Description = "Nice hotel with a great view",
                   PhoneNumber = "07433256963",
                   WebSite = "www.",
                   CityId = 1
               },
               
               new Acomodation
               {
                   Id = 2,
                   Type = AcomodationType.Hotel,
                   Address = "Str.Ion Creanga nr.2",
                   Name = "Bianca & Oana",
                   NumberOfStars = 5,
                   AcomodationPhoto = "hotel2.jpg",
                   Description = "Great hotel with a great view",
                   PhoneNumber = "07433256994",
                   WebSite = "www.bianca&oana.com",
                   CityId = 3
               },
               new Acomodation
               {
                   Id = 3,
                   Type = AcomodationType.Hotel,
                   Address = "Champselisee,no.10",
                   Name = "Raul",
                   NumberOfStars = 3,
                   AcomodationPhoto = "hotel3.jpg",
                   Description = "Best price in the city of love",
                   PhoneNumber = "07433257963",
                   WebSite = "www.raul.fr",
                   CityId = 7
               },
               new Acomodation
               {
                   Id=4,
                   Type= AcomodationType.Hotel,
                   Address= "Rue de Rivoli",
                   Name= "Hotel de Ville de Paris",
                   NumberOfStars = 4,
                   AcomodationPhoto = "hotel4.jpg",
                   Description = "Close to the city center",
                   PhoneNumber = "33142764040",
                   WebSite = "www.villeDeParis.fr",
                   CityId = 7
               }
               );

            
            context.Facilities.AddOrUpdate(
                p => p.Id,
                new Facility { Id = 1, Description = "Close to the beach" },
                new Facility { Id = 2, Description = "Close to supermarkets" },
                new Facility { Id = 3, Description = "In a quaiet area" }
               );
            
            context.Reviews.AddOrUpdate(
                p => p.Id,
                new Review { Id = 1, Date= new DateTime(2017, 08, 01), Description="I liked everything",UserId=1,AcomodationId=1},
                new Review { Id=2, Date=new DateTime(2017,08,30),Description="It was a nice stay",UserId=2,AcomodationId=2}
               );
          
            context.AcomodationFacilities.AddOrUpdate(
                p=>p.Id,
                new AcomodationFacility { Id = 1, FacilityId = 1, AcomodationId = 1 },
                new AcomodationFacility { Id = 2, FacilityId = 2, AcomodationId = 2 },
                new AcomodationFacility { Id = 3, FacilityId = 2, AcomodationId = 3 }
                );
               

        }  
    }
}
