﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Country
    {
		public int Id { get; set; }
		public string Name { get; set;}

        public string Lng { get; set; }

        public string Lat { get; set; }

        public Country()
        {

        }
        public Country(string name)
        {
            this.Name = name;
        }
    
	}
}
