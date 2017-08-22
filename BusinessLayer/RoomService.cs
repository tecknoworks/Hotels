using DataLayer;
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
		public List<Room> GetAllRooms()
		{
			return context.Rooms.ToList();
		}



        /// <summary>
        /// Returns all rooms form an acomodation
        /// </summary>
        /// <param name="acomodationId">The Id for an acomodation</param>
        public List<Room> GetRooms(int acomodationId)
        {
            return context.Rooms.Where(r => r.AcomodationId == acomodationId).ToList();
        }



        /// <summary>
        /// Returns all the room reservatuons
        /// </summary>
        public List<RoomReservation> GetAllRoomReservation()
        {
            return context.RoomReservations.ToList();
        }


		/// <summary>
		/// Returns a room reservation
		/// </summary>
		/// <param name="roomId">The Id of a room</param>
		/// <param name="reservationId">The Id for a reservation</param>
        public List<RoomReservation> GetRoomReservations(int roomId,int reservationId)
        {
            return context.RoomReservations.Include("Room").Where(rr => rr.RoomId == roomId && rr.ReservationId==reservationId).ToList();
        }


        /// <summary>
        /// Returns all the reservations
        /// </summary>
        public List<Reservation> GetAllReservations()
        {
            return context.Reservations.ToList();
        }



		/// <summary>
		/// Add a new room
		/// </summary>
		/// <param name="type">The type of a room</param>
		/// <param name="price">The price of a room</param>
		/// <param name="numberOdAdults">The number of adults</param>
		/// <param name="numberOfChildren">The number of children</param>
		/// <param name="photo">The photo of the room</param>
		/// <param name="description">The description of the room</param>
		/// <param name="numberOfRoomsAvailable">The number of rooms available</param>
		/// <param name="accomodationId">The Id of the acomodation </param>
		/// <returns>A new room</returns>
        public Room AddRoom(RoomType type,float price,int numberOdAdults,int numberOfChildren,string photo,string description,int numberOfRoomsAvailable,int accomodationId)
        {
            return new Room(type, price, numberOdAdults, numberOfChildren, photo, description, numberOfRoomsAvailable, accomodationId);
        }




		/// <summary>
		/// Add a new room reservation
		/// </summary>
		/// <param name="dateOfStart">The date of start</param>
		/// <param name="dateOfEnd">The date of end</param>
		/// <param name="roomId">The Id of a room</param>
		/// <param name="reservationId">The Id of a reservation</param>
		/// <returns>A new room reservation</returns>
        public RoomReservation AddRoomReservation(DateTime dateOfStart,DateTime dateOfEnd,int roomId,int reservationId)
        {
            return new RoomReservation(dateOfStart, dateOfEnd, roomId, reservationId);

        }
	}
}
