using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RoomReservation
    {
        public int Id { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set;}
        public int ReservationId { get; set; }
        public Reservation Reservation;
        [NotMapped]
        public float TotalPrice
        {
            get
            {
                return DateOfEnd.Date.Subtract(DateOfStart.Date).Days * Room.Price;
            }
        }
        public RoomReservation() { }
        public RoomReservation(DateTime DateOfStart,DateTime DateOfEnd,int RoomId,int ReservationId)
        {
            this.DateOfStart = DateOfStart;
            this.DateOfEnd = DateOfEnd;
            this.RoomId = RoomId;
            this.ReservationId = ReservationId;
        }
    }

}

