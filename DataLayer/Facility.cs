﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class Facility
	{
		public int Id { get; set; }
		public string Description { get; set; }
        public Facility() { }
		public Facility( string Description)
		{
			
			this.Description = Description;
		}
	}
}
