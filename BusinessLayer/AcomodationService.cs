using DataLayer;
using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
		public void GetAllCountries()
		{
			var x = context.Countries.ToList();
		}



        /// <summary>
        /// Returns all the cities
        /// </summary>
        public void GetAllCities()
        {
            var x = context.Cities.ToList();
        }



        /// <summary>
        /// Returns all cities of a country
        /// </summary>
        /// <param name="countryId">The id of the country</param>
		public void GetCities(int countryId)
		{
			var x = context.Cities.Where(c=> c.CountryId==countryId).ToList();
		}



        /// <summary>
        /// Returns all the acomodations 
        /// </summary>
        public void GetAllAcomodatioins()
        {
            var x = context.Acomodations.ToList();
        }



        /// <summary>
        /// Returns all the acomodations from a city
        /// </summary>
        /// <param name="cityId">The id of the city</param>
        public void GetAcomodations(int cityId)
        {
            var x = context.Acomodations.Where(a => a.CityId == cityId).ToList();
        }



        /// <summary>
        /// Returns all acomodations by type
        /// </summary>
        /// <param name="type">The type of the acomodation</param>
        public void GetAcomodationsByType(AcomodationType type)
        {
            var x = context.Acomodations.Where(a => a.Type == type).ToList();
        }




        /// <summary>
        /// Returns all the hotels that have the number of stars equal to the parmeter
        /// </summary>
        /// <param name="numberOfStars">The number of stars</param>
        public void GetAcomodationsByStars(int numberOfStars)
        {
            var x = context.Acomodations.Where(g => g.NumberOfStars == numberOfStars).ToList();
        }







        /// <summary>
        /// Returns all the rooms thare fit in the price range
        /// </summary>
        /// <param name="price1">The first price from the price range</param>
        /// <param name="price2">The second price from the price range</param>
        public void GetRoomsByPrice(float price1,float price2)
        {
            var x = context.Rooms.Where(a=>a.Price>=price1 && a.Price<=price2).ToList();
        }





        /// <summary>
        /// Returns all the facilities
        /// </summary>
        public void GetAllFacilities()
        {
            var x = context.Facilities.ToList();
        }




        /// <summary>
        /// Returns all the rooms order by price
        /// </summary>
        public void GetRoomsOrderByPrice(bool asc)
        {
            var x = context.Rooms.ToList();
            if (asc)
                x.OrderBy(r => r.Price);
            else
                x.OrderByDescending(r => r.Price);
        }


  
        /// <summary>
        /// Returns all the acomodations orderd by stars
        /// </summary>
        /// <param name="asc">If the parameters is asc the sortiong will be ascending</param>
        public void GetAcomodationsOrderByStars(bool asc)
        {
            var x = context.Acomodations.ToList();
            if (asc)
                x.OrderBy(r => r.NumberOfStars);
            else
                x.OrderByDescending(r => r.NumberOfStars);
        }
       
		
		/// <summary>
        /// Returns all the facilities from an acomodation
        /// </summary>
        /// <param name="acomodationId">The id of the acomodation</param>
        public void GetFacilities(int acomodationId)
        {
            var x = context.AcomodationFacilities.Where(f => f.AcomodationId == acomodationId).ToList();
        }




        /// <summary>
        /// Returns all the acomodation-facilities
        /// </summary>
        public void GetAllAcomodationFacilities()
        {
            var x = context.AcomodationFacilities.ToList();
        }




        /// <summary>
        /// Returns all the acomodation-nearbies
        /// </summary>
        public void GetAllAcomodationNearbies()
        {
            var x = context.AcomodationNearbyPlaces.ToList();
        }





        /// <summary>
        /// Returns all the nearby places for an acomodation
        /// </summary>
        /// <param name="acomodationId">The id of the acomodaion</param>
        public void GetAcomodationNearbies(int acomodationId,int nearbyId)
        {
            var x = context.AcomodationNearbyPlaces.Where(n=>n.AcomodationId==acomodationId && n.NearbyId==nearbyId).ToList();
        }

        /// <summary>
        /// Returns all the nearby places
        /// </summary>
        public void GetAllNearbyPlaces()
        {
            var x = context.NearbyPlaces.ToList();
        }




        /// <summary>
        /// Returns all the reviews
        /// </summary>
        public void GetAllReviews()
        {
            var x = context.Reviews.ToList();
        }


        /// <summary>
        /// Returns all the reviews from an acomodations
        /// </summary>
        /// <param name="acomodationId">The id of the acomodation</param>
        public void GetReviews(int acomodationId)
        {
            var x = context.Reviews.Where(r => r.AcomodationId == acomodationId).ToList();
        }






        /// <summary>
        /// Returns all the acomodation is based on facilities
        /// </summary>
        public void GetAllAcomodationBasedOnFacility(int facilityId)

        {
            var accomodation = context.AcomodationFacilities.FirstOrDefault(f => f.Id == facilityId);
            if(accomodation!=null)
            {
                var name = accomodation.Acomodation.Name.ToString();
            }
            

             
        }
      


        /// <summary>
        /// Add a new country
        /// </summary>
        /// <param name="name">The name of the county</param>
        /// <returns>A new country</returns>
        public Country AddCountry(string name)
        {
            return new Country(name);
        }




        /// <summary>
        /// Add a new city
        /// </summary>
        /// <param name="name">The name of the city</param>
        /// <param name="countryId">The country id where the city is situated</param>
        /// <returns>A new city</returns>
        public City AddCity(string name,int countryId)
        {
            return new City(name, countryId);
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
        public Acomodation AddAcomodation(AcomodationType type,string address,string name,int numberOfStars,byte[] photo,string description,string phoneNumber,string website,int cityId)
        {
            return new Acomodation(type, address, name, numberOfStars, photo, description, phoneNumber, website, cityId);
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
        public Reservation AddReservation(DateTime dateofReservation,DateTime dateOfStart,DateTime dateOfEnd,float totalPayment,int numberOfPeople,int roomReservationId,int userId)
        {
            return new Reservation(dateofReservation,dateOfStart,dateOfEnd,totalPayment,numberOfPeople,roomReservationId,userId);
        }





        /// <summary>
        /// Add new facility
        /// </summary>
        /// <param name="description">The description of the facility</param>
        /// <returns>A new facility</returns>
        public Facility AddFacility(string description)
        {
            return new Facility(description);
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
            return new Nearby(name, location, type);
        }



        /// <summary>
        /// Add a new review
        /// </summary>
        /// <param name="date">The date of the review</param>
        /// <param name="description">The description of the review</param>
        /// <param name="userId">The user who made the review</param>
        /// <param name="acomodationId">The Id of the acomodation</param>
        /// <returns></returns>
        public Review AddReview(DateTime date,string description,int userId,int acomodationId)
        {
            return new Review(date, description, userId, acomodationId);
        }


        /// <summary>
        /// Add a new acomodation nearby
        /// </summary>
        /// <param name="nearbyId">The Id of the nearby</param>
        /// <param name="acomodationId">The Id of the acomodation</param>
        /// <returns></returns>
        public AcomodationNearby AddAcomodationNearby(int nearbyId, int acomodationId)
        {
            return new AcomodationNearby(nearbyId, acomodationId);
        }


        /// <summary>
        /// Add a new acomodation facility
        /// </summary>
        /// <param name="facilityId">The Id of the facility</param>
        /// <param name="acomodationId">The Id of the acomodation</param>
        /// <returns></returns>
        public AcomodationFacility AddAcomodationFacility(int facilityId,int acomodationId)
        {
            return new AcomodationFacility(facilityId, acomodationId);
        }
    }
    
}
