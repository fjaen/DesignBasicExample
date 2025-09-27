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
            // Collections are initialized in the constructor without parameters
            this.CrewMembers = new List<Person>();
            this.Seats= new List<Seat>();
        }

        // we call :this() so that the constructor without parameters is executed
        // Person p object passed as a parameter because minimum cardinality in the model is 1
        public Flight(DateTime DepartureDate,string FlightNumber,Person p):this() {
            this.DepartureDate = DepartureDate;
            this.FlightNumber = FlightNumber;
            CrewMembers.Add(p);
        }

    }
}
