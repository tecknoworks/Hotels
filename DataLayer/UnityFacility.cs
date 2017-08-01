using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class UnityFacility
	{
		public int Id { get; set; }
		public Facility Facility { get; set; }

		public int FacilityId { get; set; }

		public Acomodation Acomodation { get; set; }

		public int AcomodationId { get; set; }

		public UnityFacility(int Id, int FacilityId, int AcomodationId) {
			this.Id = Id;
			this.FacilityId = FacilityId;
			this.AcomodationId = AcomodationId;
		}
	}
}
