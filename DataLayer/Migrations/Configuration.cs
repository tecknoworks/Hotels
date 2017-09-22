namespace DataLayer.Migrations
{
    using Hotels.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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
            //context.Users.AddOrUpdate(
            //    p=>p.Id,
            //    new ApplicationUser { Email="oana@tkw.com",PasswordHash= "d2eb8f8a-8362-4eeb-b402-51ec3a09b13d" }
            //    );
          
            context.Countries.AddOrUpdate(
              p => p.Id,
              new Country { Id = 1, Name = "Romania",Lat= "44.439663" ,Lng= "26.096306" },
              new Country { Id = 2, Name = "Hungary",Lat= "47.497912",Lng= "19.04023499999994" },
              new Country { Id = 3, Name = "Italy",Lat= "41.9027835",Lng= "12.496365500000024"},
              new Country { Id = 4, Name = "Germany",Lat= "52.520008",Lng= "13.404954 " },
              new Country { Id = 5, Name = "France",Lat= "48.864716",Lng= "2.349014" },
              new Country { Id = 6, Name = "Greece", Lat = "39.48167", Lng = "22.539261" },
              new Country { Id = 7, Name = "Spain", Lat = "40.428984", Lng = "- 3.704264" }
            );

              context.Cities.AddOrUpdate(
              p => p.Id,
              new City { Id = 1, Name = "Cluj-Napoca", CountryId = 1 ,Lat= "46.77121",Lng= "23.623635"},
              new City { Id = 2, Name = "Bucuresti", CountryId = 1,Lat= "44.439663",Lng= "26.096306 "},
              new City { Id = 3, Name = "Sibiu", CountryId = 1 ,Lat= "45.7983273",Lng= "24.12558260000003"},
              new City { Id = 4, Name = "Budapest", CountryId = 2,Lat= "47.497912",Lng= "19.04023499999994" },
              new City { Id = 5, Name = "Rome", CountryId = 3,Lat= "41.9027835",Lng= "12.496365500000024 "},
              new City { Id = 6, Name = "Berlin", CountryId = 4 , Lat = "52.520008", Lng = "13.404954" },
              new City { Id = 7, Name = "Paris", CountryId = 5,Lat= "48.864716",Lng= "2.349014" },
              new City { Id = 8, Name = " Athens", CountryId = 6, Lat = "37.984437", Lng = "23.728375" },
              new City { Id = 9, Name = "Tesaloniki", CountryId = 6, Lat = "40.640859", Lng = "22.941220" },
              new City { Id = 10, Name = "Madrid", CountryId = 7, Lat = "40.426371", Lng = "-3.704264" },
              new City { Id = 11, Name = "Zakinthos", CountryId = 6, Lat = "37.801677", Lng = "20.782125" },
              new City { Id = 12, Name = "Barcelona", CountryId = 7, Lat = "41.385754", Lng = "2.172112" },
              new City { Id = 13, Name = "Halikidiki", CountryId = 6, Lat = "40.413959", Lng = "23.400638" },
              new City { Id = 14, Name = "Valencia ", CountryId = 7, Lat = "39.470276", Lng = "-0.377999" },
              new City { Id = 15, Name = "Hajdúszoboszló", CountryId = 2, Lat = "47.445332", Lng = "21.373752" },
              new City { Id = 16, Name = "Verona", CountryId = 3, Lat = "45.438275", Lng = "10.989783" },
              new City { Id = 17, Name = "Venice", CountryId = 3, Lat = "45.491872", Lng = "12.252622" },
              new City { Id = 18, Name = "Lido di Jesolo", CountryId = 3, Lat = "45.499356", Lng = "12.619737" },
              new City { Id = 19, Name = "Munich", CountryId = 4, Lat = "48.136041", Lng = "11.580280 " },
              new City { Id = 20, Name = "Frankfurt", CountryId = 4, Lat = "50.124209", Lng = "8.666769" },
              new City { Id = 21, Name = "Marseille", CountryId = 5, Lat = "43.300430", Lng = "5.429738" },
              new City { Id = 21, Name = "Nice", CountryId = 5, Lat = "43.709870", Lng = "7.229469" }
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
                new Room{ Id = 3, Type = RoomType.Triple, Price = 70, NumberOfAdults = 2, NumberOfChildren = 1, RoomPhoto="roomT1.jpg", Description = "2 bathrooms", NumberOfRoomsAvailable = 5,AcomodationId=2 },
                new Room { Id = 4, Type = RoomType.Single, Price = 120, NumberOfAdults = 1, NumberOfChildren = 0, RoomPhoto = "roomS2.jpg", Description = "Nice view", NumberOfRoomsAvailable = 4, AcomodationId = 3 },
                new Room { Id = 5, Type = RoomType.Double, Price = 500, NumberOfAdults = 2, NumberOfChildren = 0, RoomPhoto = "roomD2.jpg", Description = "Large room", NumberOfRoomsAvailable = 3, AcomodationId = 4 },
                new Room { Id = 6, Type = RoomType.Triple, Price = 120, NumberOfAdults = 2, NumberOfChildren = 1, RoomPhoto = "roomT2.jpg", Description = "2 bathrooms", NumberOfRoomsAvailable = 5, AcomodationId = 6 },
                new Room { Id = 7, Type = RoomType.Single, Price = 300, NumberOfAdults = 1, NumberOfChildren = 0, RoomPhoto = "roomS1.jpg", Description = "Nice view", NumberOfRoomsAvailable = 4, AcomodationId = 2 },
                new Room { Id = 8, Type = RoomType.Apartment, Price = 1000, NumberOfAdults = 2, NumberOfChildren = 0, RoomPhoto = "roomA1.jpg", Description = "Large room", NumberOfRoomsAvailable = 3, AcomodationId = 7 },
                new Room { Id = 9, Type = RoomType.Triple, Price = 50, NumberOfAdults = 2, NumberOfChildren = 1, RoomPhoto = "roomT1.jpg", Description = "2 bathrooms", NumberOfRoomsAvailable = 5, AcomodationId = 2 },
                new Room { Id = 10, Type = RoomType.Single, Price = 50, NumberOfAdults = 1, NumberOfChildren = 0, RoomPhoto = "roomS1.jpg", Description = "Nice view", NumberOfRoomsAvailable = 4, AcomodationId = 3 },
                new Room { Id = 11, Type = RoomType.Double, Price = 119, NumberOfAdults = 2, NumberOfChildren = 0, RoomPhoto = "roomD1.jpg", Description = "Large room", NumberOfRoomsAvailable = 3, AcomodationId = 1 }
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
                    User_Id = "3264ce46 - b85e - 4e36 - b1a3 - 72f196cabb2b"
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
                User_Id = "487ff246-78c7-4ad3-a1a1-5790021a8139"
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
                    User_Id = "3264ce46 - b85e - 4e36 - b1a3 - 72f196cabb2b"
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
                   Description = "Nice hotel with a great view",
                   PhoneNumber = "07433256963",
                   WebSite = "www.",
                   CityId = 1,
                   Lat= "46.761050",
                   Lng= "23.608344"
               },
               
               new Acomodation
               {
                   Id = 2,
                   Type = AcomodationType.Hotel,
                   Address = "Str.Ion Creanga nr.2",
                   Name = "Bianca & Oana",
                   NumberOfStars = 5,
                   Description = "Great hotel with a great view",
                   PhoneNumber = "07433256994",
                   WebSite = "www.bianca&oana.com",
                   CityId = 3,
                   Lat= "45.7983273",
                   Lng= "24.12558260000003"
               },
               new Acomodation
               {
                   Id = 3,
                   Type = AcomodationType.Hotel,
                   Address = "Champselisee,no.10",
                   Name = "Raul",
                   NumberOfStars = 3,
                   Description = "Best price in the city of love",
                   PhoneNumber = "07433257963",
                   WebSite = "www.raul.fr",
                   CityId = 7,
                   Lat= "48.864716",
                   Lng= "2.349014"
               },
               new Acomodation
               {
                   Id=4,
                   Type= AcomodationType.Hotel,
                   Address= "Rue de Rivoli",
                   Name= "Hotel de Ville de Paris",
                   NumberOfStars = 4,
                   Description = "Close to the city center",
                   PhoneNumber = "33142764040",
                   WebSite = "www.villeDeParis.fr",
                   CityId = 7,
                   Lat= "48.856497",
                   Lng= "2.352401"
               },
                new Acomodation
                {
                    Id = 5,
                    Type = AcomodationType.Hotel,
                    Address = "Hunyadi Janos ut",
                    Name = "Grand hotel Budapesta ",
                    NumberOfStars = 2,
                    Description = "Nice hotel with a great view",
                    PhoneNumber = "1230657890",
                    WebSite = "www.ghb.hu",
                    CityId = 4,
                    Lat = "47.497912",
                    Lng = "19.04023499999994"
                },

               new Acomodation
               {
                   Id = 6,
                   Type = AcomodationType.Hotel,
                   Address = "Piazza della Repubblica",
                   Name = "Rome pension",
                   NumberOfStars = 5,
                   Description = "Great hotel with a great view",
                   PhoneNumber = "0789563125",
                   WebSite = "www.rome.com",
                   CityId = 5,
                   Lat = "41.9027835",
                   Lng = "12.496365500000024"
               },
               new Acomodation
               {
                   Id = 7,
                   Type = AcomodationType.Hotel,
                   Address = "Spandauer str",
                   Name = "Berlin City Messe",
                   NumberOfStars = 5,
                   Description = "Best price for a motel",
                   PhoneNumber = "49 30 965352051",
                   WebSite = "www.bcm.com",
                   CityId = 6,
                   Lat = "52.520008",
                   Lng = "13.404954"
               },
               new Acomodation
               {
                   Id = 8,
                   Type = AcomodationType.Hotel,
                   Address = "Piata Revolutiei",
                   Name = "International",
                   NumberOfStars = 4,
                   Description = "Big hotel with a nice view",
                   PhoneNumber = "0723653012",
                   WebSite = "www.vBucuresti.com",
                   CityId = 2,
                   Lat = "44.439663",
                   Lng = "26.096306",
               },
                new Acomodation
                {
                    Id = 9,
                    Type = AcomodationType.Hotel,
                    Address = "Χαλκιδική 630 77",
                    Name = "Ammon Zeus",
                    NumberOfStars = 4,
                    Description = "a beachfront location in the popular resort of Kallithea",
                    PhoneNumber = "30 2374 022357",
                    WebSite = "www.ammon.gr",
                    CityId = 13,
                    Lat = "40.0761",
                    Lng = "23.4495",
                },

               new Acomodation
               {
                   Id = 10,
                   Type = AcomodationType.Hotel,
                   Address = "József Attila u. 5-7.",
                   Name = "Hotel Délibáb",
                   NumberOfStars = 4,
                   Description = "Located next to the popular bath",
                   PhoneNumber = "+3652360366",
                   WebSite = "www.hoteldelibab.hu",
                   CityId = 15,
                   Lat = "47.450760",
                   Lng = "21.397733"
               },
               new Acomodation
               {
                   Id = 3,
                   Type = AcomodationType.Hotel,
                   Address = "Champselisee,no.10",
                   Name = "Raul",
                   NumberOfStars = 3,
                   Description = "Best price in the city of love",
                   PhoneNumber = "07433257963",
                   WebSite = "www.raul.fr",
                   CityId = 7,
                   Lat = "48.864716",
                   Lng = "2.349014"
               },
               new Acomodation
               {
                   Id = 4,
                   Type = AcomodationType.Hotel,
                   Address = "Rue de Rivoli",
                   Name = "Hotel de Ville de Paris",
                   NumberOfStars = 4,
                   Description = "Close to the city center",
                   PhoneNumber = "33142764040",
                   WebSite = "www.villeDeParis.fr",
                   CityId = 7,
                   Lat = "48.856497",
                   Lng = "2.352401"
               },
                new Acomodation
                {
                    Id = 1,
                    Type = AcomodationType.Hotel,
                    Address = "Str.Nicoara Moise nr.10",
                    Name = "Belagio",
                    NumberOfStars = 3,
                    Description = "Nice hotel with a great view",
                    PhoneNumber = "07433256963",
                    WebSite = "www.",
                    CityId = 1,
                    Lat = "46.761050",
                    Lng = "23.608344"
                },

               new Acomodation
               {
                   Id = 2,
                   Type = AcomodationType.Hotel,
                   Address = "Str.Ion Creanga nr.2",
                   Name = "Bianca & Oana",
                   NumberOfStars = 5,
                   Description = "Great hotel with a great view",
                   PhoneNumber = "07433256994",
                   WebSite = "www.bianca&oana.com",
                   CityId = 3,
                   Lat = "45.7983273",
                   Lng = "24.12558260000003"
               },
               new Acomodation
               {
                   Id = 3,
                   Type = AcomodationType.Hotel,
                   Address = "Champselisee,no.10",
                   Name = "Raul",
                   NumberOfStars = 3,
                   Description = "Best price in the city of love",
                   PhoneNumber = "07433257963",
                   WebSite = "www.raul.fr",
                   CityId = 7,
                   Lat = "48.864716",
                   Lng = "2.349014"
               },
               new Acomodation
               {
                   Id = 4,
                   Type = AcomodationType.Hotel,
                   Address = "Rue de Rivoli",
                   Name = "Hotel de Ville de Paris",
                   NumberOfStars = 4,
                   Description = "Close to the city center",
                   PhoneNumber = "33142764040",
                   WebSite = "www.villeDeParis.fr",
                   CityId = 7,
                   Lat = "48.856497",
                   Lng = "2.352401"
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
                new Review { Id = 1, Date= new DateTime(2017, 08, 01), Description="I liked everything", User_Id = "3264ce46 - b85e - 4e36 - b1a3 - 72f196cabb2b", AcomodationId=1},
                new Review { Id=2, Date=new DateTime(2017,08,30),Description="It was a nice stay", User_Id = "3264ce46 - b85e - 4e36 - b1a3 - 72f196cabb2b", AcomodationId=2}
               );

            context.Photos.AddOrUpdate(
               p => p.Id,
               new Photo { Id = 1, AccomodationPhoto = "hotel1.jpg", AcomodationId = 1 },
               new Photo { Id = 2, AccomodationPhoto = "hotel1a.jpg", AcomodationId = 1 },
               new Photo { Id = 3, AccomodationPhoto = "hotel1b.jpg", AcomodationId = 1 },
               new Photo { Id = 4, AccomodationPhoto = "hotel2.jpg", AcomodationId = 2 },
               new Photo { Id = 5, AccomodationPhoto = "hotel2a.jpg", AcomodationId = 2 },
               new Photo { Id = 6, AccomodationPhoto = "hotel2b.jpg", AcomodationId = 2 }
                );
          
            context.AcomodationFacilities.AddOrUpdate(
                p=>p.Id,
                new AcomodationFacility { Id = 1, FacilityId = 1, AcomodationId = 1 },
                new AcomodationFacility { Id = 2, FacilityId = 2, AcomodationId = 2 },
                new AcomodationFacility { Id = 3, FacilityId = 2, AcomodationId = 3 }
                );

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Regular"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Regular" };

                manager.Create(role);
            }

            var usr = "bianca@tkw.com";
            if (!context.Users.Any(u => u.UserName == usr))
            {
                var passwordHash = new PasswordHasher();
                string password = passwordHash.HashPassword("!23Qwe");
                context.Users.AddOrUpdate(
                    u => u.UserName,
                    new ApplicationUser
                    {
                        UserName = usr,
                        Email = "bianca@tkw.com",
                        PasswordHash = password,
                        SecurityStamp = Guid.NewGuid().ToString("D")
                    }
                    );
            }
        }  
    }
}
