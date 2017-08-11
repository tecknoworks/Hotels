using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class Acomodation
	{
		public int Id { get; set; }

		public AcomodationType Type { get; set; }
        [NotMapped]
        public string AcomodationType
        {
            get
            {
                return Type.ToString();
            }
        }
        public string Address { get; set; }
        public string Name { get; set; }
		public int NumberOfStars { get; set; }
		public byte[] Picture { get; set; }
		public string Description { get; set; }
		public string PhoneNumber { get; set; }
		public string WebSite { get; set; }
		public int CityId { get; set; }
		public City City { get; set; }
        public Acomodation(AcomodationType Type, string Address,string Name, int NumberOfStars, byte[] Picture, string Description, string PhoneNumber, string WebSite,int CityId)
		{
			this.Type = Type;
			this.Address = Address;
            this.Name = Name;
			this.NumberOfStars = NumberOfStars;
			this.Picture = Picture;
			this.Description = Description;
			this.PhoneNumber = PhoneNumber;
			this.WebSite = WebSite;
			this.CityId = CityId;
		}
        public Acomodation() { }
    }
}
