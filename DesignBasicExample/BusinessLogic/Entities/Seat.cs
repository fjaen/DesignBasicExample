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
        public Seat(string Number,Flight f,Person p) {
            this.Number = Number;
            this.Flight = f;
            this.Person = p;
        }
    }
}
