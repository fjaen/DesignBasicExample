using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBasicExample.Entities
{
    public partial class Person
    {
        public string DNI { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //Flight-Person (CrewMembers) M to M
        public virtual ICollection<Flight> Flights_Crew { get; set; }

        //Person-Seat M
        public virtual ICollection<Seat> SeatsasPassenger {  get; set; }

    }

}
