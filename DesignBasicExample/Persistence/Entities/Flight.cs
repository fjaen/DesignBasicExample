using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBasicExample.Entities
{
    public partial class Flight
    {
        public string FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }

        //Flight-Person (CrewMembers) M to M
        public virtual ICollection<Person> CrewMembers { get; set; }
        //Flight-Seat M
        public virtual ICollection<Seat> Seats { get; set; }

    }
}
