using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AcomodationFacilityService
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void getAllAcomodationFacilities()
        {
            var x = context.UnityFacilities.ToList();
        }
    }
}
