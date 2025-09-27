using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBasicExample.Entities
{
    public partial class Seat
    {
        public string Number {  get; set; }

        //1 relationship with Person and Flight
        public virtual Person Person { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
