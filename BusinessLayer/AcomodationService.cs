using DataLayer;
using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AcomodationService
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        /// <summary>
        /// Returns all the countries
        /// </summary>
		public List<Country> GetAllCountries()
		{
			return context.Countries.ToList();
		}



        /// <summary>
        /// Returns all the cities
        /// </summary>
        public List<City> GetAllCities()
        {
            return  context.Cities.ToList();
        }



        /// <summary>
        /// Returns all cities of a country
        /// </summary>
        /// <param name="countryId">The id of the country</param>
		public List<City> GetCities(int countryId)
		{
			return context.Cities.Where(c=> c.CountryId==countryId).ToList();
		}



        /// <summary>
        /// Returns all the acomodations 
        /// </summary>
        public List<Acomodation> GetAllAcomodations()
        {
            return context.Acomodations.ToList();
        }

        /// <summary>
        /// Return all the photos from an acomodation
        /// </summary>
        /// <param name="acomodationId">The id of the acomodation</param>
        /// <returns></returns>
        public List<Photo>GetPhotos(int acomodationId)
        {
            return context.Photos.Include("Acomodation").Where(a => a.AcomodationId == acomodationId).ToList();
        }


        /// <summary>
        /// Returns all the acomodations from a city
        /// </summary>
        /// <param name="cityId">The id of the city</param>
        public List<Acomodation> GetAcomodations(int cityId)
        {
            return context.Acomodations.Where(a => a.CityId == cityId).ToList();
        }



        /// <summary>
        /// Returns all acomodations by type
        /// </summary>
        /// <param name="type">The type of the acomodation</param>
        public List<Acomodation> GetAcomodationsByType(AcomodationType type)
        {
            return context.Acomodations.Where(a => a.Type == type).ToList();
        }




        /// <summary>
        /// Returns all the hotels that have the number of stars equal to the parmeter
        /// </summary>
        /// <param name="numberOfStars">The number of stars</param>
        public List<Acomodation> GetAcomodationsByStars(int numberOfStars)
        {
            return context.Acomodations.Where(g => g.NumberOfStars == numberOfStars).ToList();
        }







        /// <summary>
        /// Returns all the rooms thare fit in the price range
        /// </summary>
        /// <param name="price1">The first price from the price range</param>
        /// <param name="price2">The second price from the price range</param>
        public List<Room> GetRoomsByPrice(float price1,float price2)
        {
            return context.Rooms.Where(a=>a.Price>=price1 && a.Price<=price2).ToList();
        }





        /// <summary>
        /// Returns all the facilities
        /// </summary>
        public List<Facility> GetAllFacilities()
        {
            return context.Facilities.ToList();
        }




        /// <summary>
        /// Returns all the rooms order by price
        /// </summary>
        public List<Room>  GetRoomsOrderByPrice(bool asc)
        {
            var x = context.Rooms.ToList();
            if (asc)
                x.OrderBy(r => r.Price);
            else
                x.OrderByDescending(r => r.Price);
            return x;
        }


  
        /// <summary>
        /// Returns all the acomodations orderd by stars
        /// </summary>
        /// <param name="asc">If the parameters is asc the sortiong will be ascending</param>
        public List<Acomodation> GetAcomodationsOrderByStars(bool asc)
        {
            var x = context.Acomodations.ToList();
            if (asc)
                x.OrderBy(r => r.NumberOfStars);
            else
                x.OrderByDescending(r => r.NumberOfStars);

            return x;
        }
       
		
		/// <summary>
        /// Returns all the facilities from an acomodation
        /// </summary>
        /// <param name="acomodationId">The id of the acomodation</param>
        public List<AcomodationFacility> GetFacilities(int acomodationId)
        {
            var facility = context.AcomodationFacilities.Include("Facility").Where(f => f.AcomodationId == acomodationId).ToList();
            return facility;
        }




        /// <summary>
        /// Returns all the acomodation-facilities
        /// </summary>
        public List<AcomodationFacility> GetAllAcomodationFacilities()
        {
            return context.AcomodationFacilities.ToList();
        }




        /// <summary>
        /// Returns all the acomodation-nearbies
        /// </summary>
        public List <AcomodationNearby> GetAllAcomodationNearbies()
        {
            return context.AcomodationNearbyPlaces.ToList();
        }





        /// <summary>
        /// Returns all the nearby places for an acomodation
        /// </summary>
        /// <param name="acomodationId">The id of the acomodaion</param>
        public List<AcomodationNearby> GetAcomodationNearbies(int acomodationId,int nearbyId)
        {
            return context.AcomodationNearbyPlaces.Where(n=>n.AcomodationId==acomodationId && n.NearbyId==nearbyId).ToList();
        }

        /// <summary>
        /// Returns all the nearby places
        /// </summary>
        public List<Nearby> GetAllNearbyPlaces()
        {
            return context.NearbyPlaces.ToList();
        }




        /// <summary>
        /// Returns all the reviews
        /// </summary>
        public List<Review> GetAllReviews()
        {
            return context.Reviews.ToList();
        }


        /// <summary>
        /// Returns all the reviews from an acomodations
        /// </summary>
        /// <param name="acomodationId">The id of the acomodation</param>
        public List<Review> GetReviews(int acomodationId)
        {
            return context.Reviews.Where(r => r.AcomodationId == acomodationId).ToList();
        }






        /// <summary>
        /// Returns all the acomodation is based on facilities
        /// !!!!!!!</summary>
        public string GetAllAcomodationBasedOnFacility(int facilityId)

        {
            var accomodation = context.AcomodationFacilities.FirstOrDefault(f => f.Id == facilityId);
            if(accomodation!=null)
            {
                return accomodation.Acomodation.Name.ToString();
            }

            return null;

             
        }
      


        /// <summary>
        /// Add a new country
        /// </summary>
        /// <param name="name">The name of the county</param>
        /// <returns>A new country</returns>
        public Country AddCountry(string name)
        {
            Country country = new Country(name);
            context.Countries.Add(country);
            context.SaveChanges();
            return country;
        }




        /// <summary>
        /// Add a new city
        /// </summary>
        /// <param name="name">The name of the city</param>
        /// <param name="countryId">The country id where the city is situated</param>
        /// <returns>A new city</returns>
        public City AddCity(string name,int countryId)
        {
            City city= new City(name, countryId);
            context.Cities.Add(city);
            context.SaveChanges();
            return city;

        }



        /// <summary>
        /// Add a new acomodation
        /// </summary>
        /// <param name="type">The type of the acomodation</param>
        /// <param name="address">The address of the acomodation</param>
        /// <param name="name">The name of the acomodaion</param>
        /// <param name="numberOfStars">The number of stars that the acomodation has</param>
        /// <param name="photo">The photo of the acomodation</param>
        /// <param name="description">The description of the acomodation</param>
        /// <param name="phoneNumber">The phone number of the acomodaion</param>
        /// <param name="website">The website of the acomodation</param>
        /// <param name="cityId">The id of the city where the acomodation is situated</param>
        /// <returns></returns>
        public Acomodation AddAcomodation(AcomodationType type,string address,string name,int numberOfStars,string description,string phoneNumber,string website,int cityId,string lat,string lng)
        {
            Acomodation accomodation= new Acomodation(type, address, name, numberOfStars,  description, phoneNumber, website, cityId,lat,lng);
            context.Acomodations.Add(accomodation);
            context.SaveChanges();
            return accomodation;
        }





        /// <summary>
        /// Add a new reservation
        /// </summary>
        /// <param name="dateofReservation">The date when the reservation is made</param>
        /// <param name="dateOfStart">The date of start</param>
        /// <param name="dateOfEnd">The date that the resrvation ends</param>
        /// <param name="totalPayment">The total price of the reservation</param>
        /// <param name="numberOfPeople">The number of people</param>
        /// <param name="roomReservationId">The id of the room </param>
        /// <param name="userId">The id of the user who made the reservation</param>
        /// <returns></returns>
        public Reservation AddReservation(DateTime dateOfStart, DateTime dateOfEnd, float totalPayment, int numberOfPeople,int roomId,string userId)
        {
            Reservation reservation= new Reservation(DateTime.Now, dateOfStart.Date, dateOfEnd.Date, totalPayment, numberOfPeople, roomId, userId);
            context.Reservations.Add(reservation);

            Room room = context.Rooms.FirstOrDefault(r => r.Id == roomId);
            if (room.NumberOfRoomsAvailable > 0)
            {
                room.NumberOfRoomsAvailable--;
            }
            

            context.SaveChanges();

            return reservation; 
        }





        /// <summary>
        /// Add new facility
        /// </summary>
        /// <param name="description">The description of the facility</param>
        /// <returns>A new facility</returns>
        public Facility AddFacility(string description)
        {
            Facility facility= new Facility(description);
            context.Facilities.Add(facility);
            context.SaveChanges();
            return facility;
        }



        /// <summary>
        /// Add a new nearby
        /// </summary>
        /// <param name="name">The name of the nearby place</param>
        /// <param name="location">The location of the nearby place</param>
        /// <param name="type">The type of the nearby place</param>
        /// <returns>A new nearby place</returns>
        public Nearby AddNearby(string name,string location,NearbyType type)
        {
            Nearby nearby=new Nearby(name, location, type);
            context.NearbyPlaces.Add(nearby);
            context.SaveChanges();
            return nearby;
        }



        /// <summary>
        /// Add a new review
        /// </summary>
        /// <param name="date">The date of the review</param>
        /// <param name="description">The description of the review</param>
        /// <param name="userId">The user who made the review</param>
        /// <param name="acomodationId">The Id of the acomodation</param>
        /// <returns></returns>
        public Review AddReview(DateTime date,string description,int acomodationId)
        {
            Review review= new Review(date, description, acomodationId);
            context.Reviews.Add(review);
            context.SaveChanges();
            return review;
        }


        /// <summary>
        /// Add a new acomodation nearby
        /// </summary>
        /// <param name="nearbyId">The Id of the nearby</param>
        /// <param name="acomodationId">The Id of the acomodation</param>
        /// <returns></returns>
        public AcomodationNearby AddAcomodationNearby(int nearbyId, int acomodationId)
        {
            AcomodationNearby accomodationNearby=new AcomodationNearby(nearbyId, acomodationId);
            context.AcomodationNearbyPlaces.Add(accomodationNearby);
            context.SaveChanges();
            return accomodationNearby;
        }


        /// <summary>
        /// Add a new acomodation facility
        /// </summary>
        /// <param name="facilityId">The Id of the facility</param>
        /// <param name="acomodationId">The Id of the acomodation</param>
        /// <returns></returns>
        public AcomodationFacility AddAcomodationFacility(int facilityId,int acomodationId)
        {
            return null;// new AcomodationFacility(facilityId, acomodationId);
        }

        /// <summary>
        /// Returns the total price based on the number of days
        /// </summary>
        /// <param name="dateOfStart">The start date of the reservation </param>
        /// <param name="dateOfEnd">The end date of the reservation</param>
        /// <param name="price">The price of the room</param>
        /// <returns></returns>
        public float GetTotalPayment(DateTime dateOfStart,DateTime dateOfEnd,float price)
        {
            var date = dateOfEnd.Date - dateOfStart.Date;

            return date.Days * price;
        }
        public List<Reservation> GetReservation(int roomId)
        {
            return context.Reservations.Where(r => r.RoomReservationId == roomId).ToList();
        }

    }

}
