﻿using Hotels.Models;
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

		public void GetAllRooms()
		{
			var x = context.Rooms.ToList();
		}
	}
}
