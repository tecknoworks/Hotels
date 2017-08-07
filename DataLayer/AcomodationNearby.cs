using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class AcomodationNearby
	{
		public int Id { get; set; }

		public Nearby Nearby { get; set; }

		public int NearbyId { get; set; }

		public Acomodation Acomodation { get; set; }

		public int  AcomodationId { get; set; }

        public AcomodationNearby()
        {
                
        }
        public AcomodationNearby(int nearbyId,int acomodationId)
        {
            this.NearbyId = nearbyId;
            this.AcomodationId = acomodationId;
        }

	}
}
