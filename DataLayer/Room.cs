using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType Type { get; set; }
        public float Price { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
        public int NumberOfRoomsAvailable { get; set; }

        public int AcomodationId { get; set; }

        public Acomodation Acomodation { get; set; }
        public Room() { }
        public Room(RoomType Type, float Price, int NumberOfAdults, int NumberOfChildren, byte[] Photo, string Description, int NumberOfRoomsAvailable,int AcomodationId)
        {
           // this.Id = Id;
            this.Type = Type;
            this.Price = Price;
            this.NumberOfAdults = NumberOfAdults;
            this.NumberOfChildren = NumberOfChildren;
            this.Photo = Photo;
            this.Description = Description;
            this.NumberOfRoomsAvailable = NumberOfRoomsAvailable;
            this.AcomodationId = AcomodationId;
        }
    }
}
