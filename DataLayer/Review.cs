﻿using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Review
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public string  User_Id { get; set; }
        public ApplicationUser User { get; set; }

        public int AcomodationId { get; set; }
        public Acomodation Acomodation { get; set; }
        public Review() { }
        public Review(DateTime Date,string Description,int AcomodationId)
        {
            
            this.Date = Date;
            this.Description = Description;
            //this.User_Id = UserId;
            this.AcomodationId = AcomodationId;

        }
    }
}
