using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FacilityService
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void getAllFacilities()
        {
            var x = context.Facilities.ToList();
        }
    }
}
