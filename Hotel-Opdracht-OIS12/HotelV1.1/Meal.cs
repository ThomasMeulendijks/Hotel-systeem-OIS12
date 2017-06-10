using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    enum Mealtype
    {
        Dinner,
        Breakfast
    }
    class Meal
    {
        // PRIVATE FIELDS

        // PUBLIC PROPERTIES
        public DateTime DateTime { get; set; }

        public List<Guest> Guests { get; set; }
        // CONSTRUCTORS

        // METHODS

        // EVENT HANDLERS
    }
}
