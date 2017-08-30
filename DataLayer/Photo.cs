using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Photo
    {
        public int Id { get; set; }
        public string AcomodationPhoto{ get; set; }

        public int AcomodationId { get; set; }

        public Acomodation Acomodation { get; set; }
        public Photo()
        {

        }
        public Photo(int id,string acomodationPhoto,int acomodationId)
        {
            this.Id = id;
            this.AcomodationPhoto = acomodationPhoto;
            this.AcomodationId = acomodationId;
        }
    }
}
