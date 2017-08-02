using System;
using System.Collections.Generic;
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
        public RoomReservation(int Id,DateTime DateOfStart,DateTime DateOfEnd,int RoomId,int ReservationId)
        {
            this.Id = Id;
            this.DateOfStart = DateOfStart;
            this.DateOfEnd = DateOfEnd;
            this.RoomId = RoomId;
            this.ReservationId = ReservationId;
        }
    }

}

