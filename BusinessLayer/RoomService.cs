using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class RoomService
	{
		private ApplicationDbContext context = new ApplicationDbContext();

        /// <summary>
        /// Returns all rooms
        /// </summary>
		public void GetAllRooms()
		{
			var x = context.Rooms.ToList();
		}

        /// <summary>
        /// Returns all rooms form an acomodation
        /// </summary>
        /// <param name="acomodationId"></param>
        public void GetRooms(int acomodationId)
        {
            var x = context.Rooms.Where(r => r.AcomodationId == acomodationId).ToList();
        }

        /// <summary>
        /// Returns all the room reservatuons
        /// </summary>
        public void GetAllRoomReservation()
        {
            var x = context.RoomReservations.ToList();
        }

        public void getRoomReservations(int roomId,int reservationId)
        {
            var x = context.RoomReservations.Where(rr => rr.RoomId == roomId && rr.ReservationId==reservationId).ToList();
        }

        /// <summary>
        /// Returns all the reservations
        /// </summary>
        public void getAllReservations()
        {
            var x = context.Reservations.ToList();
        }

    }
}
