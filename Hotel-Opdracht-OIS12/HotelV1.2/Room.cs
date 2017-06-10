using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Room
    {
        // PRIVATE FIELDS

        // PUBLIC PROPERTIES
        public int RoomNumber { get; set; }
        public int RoomSize { get; set; }

        public List<Guest> Guests { get; set; }
        // CONSTRUCTORS
        public Room(int roomNumber, int size)
        {
            RoomNumber = roomNumber;
            RoomSize = size;
        }
        public Room(int roomNumber,int size, List<Guest> guests)
        {
        
            RoomNumber = roomNumber;
            RoomSize = size;
            Guests = guests;
        }
        // METHODS
        public override string ToString()
        {
            return "Room: " + Convert.ToString(RoomNumber) + " Size: " + Convert.ToString(RoomSize);
        }

        // EVENT HANDLERS
    }
}
