using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AcomodationNearby
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void getAllAcomodationNearbies()
        {
            var x = context.UnityNearbyPlaces.ToList();
        }
    }
}
