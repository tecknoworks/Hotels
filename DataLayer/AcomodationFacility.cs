using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class AcomodationFacility
	{
		public int Id { get; set; }
		public Facility Facility { get; set; }

		public int FacilityId { get; set; }

		public Acomodation Acomodation { get; set; }

		public int AcomodationId { get; set; }
        public AcomodationFacility() { }
		public AcomodationFacility(int FacilityId, int AcomodationId) {
			
			this.FacilityId = FacilityId;
			this.AcomodationId = AcomodationId;


		}
    }
}
