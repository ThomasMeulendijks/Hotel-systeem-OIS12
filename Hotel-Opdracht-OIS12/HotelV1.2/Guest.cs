using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Guest
    {
        // PRIVATE FIELDS

        // PUBLIC PROPERTIES
        public string Name { get; set; }

        public string Adres { get; set; }

        public Room Room { get; set; }
        public List<Meal> Meals { get; set; }

        // CONSTRUCTORS
        public Guest(string name, string adres)
        {
            Name = name;
            Adres = adres;
        }

        public Guest(string name, string adres, Room room)
        {
            Name = name;
            Adres = adres;
            Room = room;
        }
        // METHODS
        public override string ToString()
        {
            return Name;
        }
        // EVENT HANDLERS

    }
}
