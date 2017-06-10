using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Booking
    {
        // PRIVATE FIELDS

        // PUBLIC PROPERTIES
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }

        public List<Guest> Guests { get; set; }
        public Room Room { get; set; }

        // CONSTRUCTORS

        // METHODS

        // EVENT HANDLERS
    }
}
