using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBasicExample.Entities
{
    public partial class Flight
    {
        public Flight()
        {
            this.CrewMembers = new List<Person>();
            this.Seats= new List<Seat>();
        }
        public Flight(DateTime DepartureDate,string FlightNumber,Person p):this() {
            this.DepartureDate = DepartureDate;
            this.FlightNumber = FlightNumber;
            CrewMembers.Add(p);
        }

    }
}
