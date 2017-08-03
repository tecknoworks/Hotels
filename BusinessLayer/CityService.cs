using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
	public class CityService
	{
		private ApplicationDbContext context = new ApplicationDbContext();

		public void GetAllCities()
		{
			var x = context.Countries.ToList();
		}
	}
}
