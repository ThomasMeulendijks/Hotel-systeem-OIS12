using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Booking
    {
        // PRIVATE FIELDS

        // PUBLIC PROPERTIES
        public string BookingName { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }

        public List<Guest> Guests { get; set; }
        public Room Room { get; set; }

        // CONSTRUCTORS
        public Booking(string bookingName , DateTime dateTimeStart, DateTime dateTimeEnd, List<Guest> guests, Room room)
        {
            BookingName = bookingName;
            DateTimeStart = dateTimeStart;
            DateTimeEnd = dateTimeEnd;
            Guests = guests;
            Room = room;
        }

        // METHODS

        // EVENT HANDLERS
    }
}
