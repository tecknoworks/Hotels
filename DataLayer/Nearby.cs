using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class Nearby
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }

		public NearbyType Type { get; set; }

		public Nearby()
		{

		}
		public Nearby(int Id, string Name, string Location,NearbyType Type)
		{
			
			this.Id = Id;
			this.Name = Name;
			this.Location = Location;
			this.Type = Type;
		}

	}
}
