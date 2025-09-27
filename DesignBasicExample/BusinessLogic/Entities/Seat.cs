using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBasicExample.Entities
{
    public partial class Seat
    {
        public Seat() { }

        // Flight and Person objects passed as parameters because minimum cardinalities are 1
        public Seat(string Number,Flight f,Person p) {
            this.Number = Number;
            this.Flight = f;
            this.Person = p;
        }
    }
}
