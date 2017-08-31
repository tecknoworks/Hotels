using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    public class Photo
    {
        public int Id { get; set; }
        public string AccomodationPhoto{ get; set; }

        public int AcomodationId { get; set; }

        public Acomodation Acomodation { get; set; }
        public Photo()
        {

        }
        public Photo(int id,string acomodationPhoto,int acomodationId)
        {
            this.Id = id;
            this.AccomodationPhoto = acomodationPhoto;
            this.AcomodationId = acomodationId;
        }
    }
}
