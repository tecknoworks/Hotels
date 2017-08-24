using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class City
	{
      
        public int Id { get; set; }
		public string Name { get; set; }
		public int CountryId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
		public Country Country { get; set; }
        public City()
        {

        }
        public City(string name, int countryId)
        {
            Name = name;
            CountryId = countryId;
        }


    }
}
