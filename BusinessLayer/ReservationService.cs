using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ReservationService
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void getAllReservations()
        {
            var x = context.Reservations.ToList();
        }
    }
}
