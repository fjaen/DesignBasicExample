using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBasicExample.Entities
{
    public partial class Person
    {
        public Person() {
            Flights_Crew= new List<Flight>();
            SeatsasPassenger= new List<Seat>();
        }

        public Person(string Address, string DNI,string Name):this() {
            this.Address = Address;
            this.DNI = DNI;
            this.Name = Name;
        }
    }
}
