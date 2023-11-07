using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string EmployemHealthInformation{ get; set; }
        public string Nationality { get; set; }
        public string HealthInformation { get; set; }
    }
}
