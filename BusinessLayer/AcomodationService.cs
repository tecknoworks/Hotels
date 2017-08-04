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
        /// <param name="countryId">Integer</param>
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
        /// <param name="cityId">Integer</param>
        public void GetAcomodations(int cityId)
        {
            var x = context.Acomodations.Where(a => a.CityId == cityId).ToList();
        }

        /// <summary>
        /// Returns all acomodations by type
        /// </summary>
        /// <param name="type">AcomodationType</param>
        public void GetAcomodationsByType(AcomodationType type)
        {
            var x = context.Acomodations.Where(a => a.Type == type).ToList();
        }

        /// <summary>
        /// Returns all the hotels that have the number of stars equal to the parmeter
        /// </summary>
        /// <param name="numberOfStars"></param>
        public void GetAcomodationsByStars(int numberOfStars)
        {
            var x = context.Acomodations.Where(g => g.NumberOfStars == numberOfStars).ToList();
        }

        /// <summary>
        /// Returns all the rooms thare fit in the price range
        /// </summary>
        /// <param name="price1">Integer</param>
        /// <param name="price2">Integer</param>
        public void GetRoomsByPrice(float price1,float price2)
        {
            var x = context.Rooms.Where(a=>a.Price>=price1 && a.Price<=price2).ToList();
        }

        /// <summary>
        /// Returns all the facilities
        /// </summary>
        public void getAllFacilities()
        {
            var x = context.Facilities.ToList();
        }

        /// <summary>
        /// Returns all the rooms order by price
        /// </summary>
        public void GetRoomsOrderByPrice()
        {
            var x = context.Rooms.ToList().OrderBy(r => r.Price);
        }

        public void GetAcomodationsOrderByStars()
        {
            var x = context.Acomodations.ToList().OrderBy(a => a.NumberOfStars);
        }
        /// <summary>
        /// Returns all the facilities from an acomodation
        /// </summary>
        /// <param name="acomodationId"></param>
        public void getFacilities(int acomodationId)
        {
            var x = context.UnityFacilities.Where(f => f.AcomodationId == acomodationId).ToList();
        }

        /// <summary>
        /// Returns all the acomodation-facilities
        /// </summary>
        public void getAllAcomodationFacilities()
        {
            var x = context.UnityFacilities.ToList();
        }

        /// <summary>
        /// Returns all the acomodation-nearbies
        /// </summary>
        public void getAllAcomodationNearbies()
        {
            var x = context.UnityNearbyPlaces.ToList();
        }

        /// <summary>
        /// Returns all the nearby places for an acomodation
        /// </summary>
        /// <param name="acomodationId"></param>
        public void getAcomodationNearbies(int acomodationId,int nearbyId)
        {
            var x = context.UnityNearbyPlaces.Where(n=>n.AcomodationId==acomodationId && n.NearbyId==nearbyId).ToList();
        }

        /// <summary>
        /// Returns all the nearby places
        /// </summary>
        public void geAllNearbyPlaces()
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
        /// <param name="acomodationId"></param>
        public void GetReviews(int acomodationId)
        {
            var x = context.Reviews.Where(r => r.AcomodationId == acomodationId).ToList();
        }

        /// <summary>
        /// Returns all the acomodation is based on facilities
        /// </summary>
        public void getAllAcomodationBasedOnFacility()
        {
            var innerJoin = from a in context.UnityFacilities.ToList()
                            join f in context.Facilities.ToList() on a.FacilityId equals f.Id
                            select a.AcomodationId;
           

        }
    }
}
