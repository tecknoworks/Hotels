using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AcomodationService
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void getAllAcomodatioins()
        {
            var x = context.Acomodations.ToList();
        }
    }
}
