using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class Acomodation
	{
		public int Id { get; set; }
		public AcomodationType Type { get; set; }
		public string Address { get; set; }
		public int NumberOfStars { get; set; }
		public byte[] Picture { get; set; }
		public string Description { get; set; }
		public string PhoneNumber { get; set; }
		public string WebSite { get; set; }

		public Acomodation(int Id, AcomodationType Type, string Address, int NumberOfStars, byte[] Picture, string Description, string PhoneNumber, string WebSite)
		{
			this.Id = Id;
			this.Type = Type;
			this.Address = Address;
			this.NumberOfStars = NumberOfStars;
			this.Picture = Picture;
			this.Description = Description;
			this.PhoneNumber = PhoneNumber;
			this.WebSite = WebSite;
		}
	}
}
