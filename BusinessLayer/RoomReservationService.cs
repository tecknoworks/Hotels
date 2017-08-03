using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class RoomReservationService
	{
		private ApplicationDbContext context = new ApplicationDbContext();

		public void GetAllRoomReservation()
		{
			var x = context.RoomReservations.ToList();
		}
	}
}
