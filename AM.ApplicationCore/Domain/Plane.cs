using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //2éme methode pour crer la classe enum 

    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public IList<Flight> Flights { get; set;}
    }
}
