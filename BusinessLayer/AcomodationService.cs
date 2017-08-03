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

		public void GetAllCountries()
		{
			var x = context.Countries.ToList();
		}

		public void GetCities(int countryId)
		{
			var x = context.Cities.Where(c=> c.CountryId==countryId).ToList();
		}

		//public void GetAllAcomodatioins()
  //      {
  //          var x = context.Acomodations.ToList();
  //      }

	
	}
}
