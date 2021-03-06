﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType Type { get; set; }

        [NotMapped]
        public string RoomType
        {
            get
            {
                return Type.ToString();
            }
        }
        public float Price { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public string RoomPhoto { get; set; }
        public string Description { get; set; }
        public int NumberOfRoomsAvailable { get; set; }

        public int AcomodationId { get; set; }
        [NotMapped]
        public int NrOfPeople {

            get
            {
                return NumberOfAdults + NumberOfChildren;
            }
        }
        public Acomodation Acomodation { get; set; }
        public Room() { }
        public Room(RoomType Type, float Price, int NumberOfAdults, int NumberOfChildren, string Description, int NumberOfRoomsAvailable,int AcomodationId)
        {
           
            this.Type = Type;
            this.Price = Price;
            this.NumberOfAdults = NumberOfAdults;
            this.NumberOfChildren = NumberOfChildren;
            //this.RoomPhoto = RoomPhoto;
            this.Description = Description;
            this.NumberOfRoomsAvailable = NumberOfRoomsAvailable;
            this.AcomodationId = AcomodationId;
        }
    }
}
