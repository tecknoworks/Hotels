﻿using System;
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
        public string Address { get; set; }
        public string Name { get; set; }
		public int NumberOfStars { get; set; }

        
		public string Description { get; set; }
		public string PhoneNumber { get; set; }
		public string WebSite { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int CityId { get; set; }
		public City City { get; set; }
        public string AcomodationPhoto { get; set;}
        [NotMapped]
        public string AcomodationType
        {
            get
            {
                return Type.ToString();
            }
        }
        [NotMapped]
        public string Stars
        {
            get
            { string stars;
                switch (NumberOfStars)
                {
                    case 1 :
                        stars = "&#11088;";
                        break;
                    case 2:
                        stars = "&#11088;&#11088;";
                        break;
                    case 3:
                        stars = "&#11088;&#11088;&#11088;";
                        break;
                    case 4:
                        stars = "&#11088;&#11088;&#11088;&#11088;";
                        break;
                    case 5:
                        stars = "&#11088;&#11088;&#11088;&#11088;&#11088;";
                        break;
                    default:
                        stars = string.Empty;
                        break;
                }
                return stars;
            }
        }
        public Acomodation(AcomodationType Type, string Address,string Name, int NumberOfStars, string AcomodationPhoto, string Description, string PhoneNumber, string WebSite,int CityId)
		{
			this.Type = Type;
			this.Address = Address;
            this.Name = Name;
			this.NumberOfStars = NumberOfStars;
			this.AcomodationPhoto = AcomodationPhoto;
			this.Description = Description;
			this.PhoneNumber = PhoneNumber;
			this.WebSite = WebSite;
			this.CityId = CityId;
		}
        public Acomodation() { }
    }
}
