using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NearbyService
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void geAllNearbyPlaces()
        {
            var x = context.NearbyPlaces.ToList();
        }
    }
}
