using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hotel;

namespace HotelV1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // PRIVATE FIELDS
        // PUBLIC PROPERTIES
        public List<Room> Rooms { get; private set; }
        public List<Booking> Bookings { get; private set; }

        //CONSTRUCTOR
        public MainWindow()
        {
            InitializeComponent();
            Rooms = GetRooms();
            Bookings = new List<Booking>();
        }

        //METHODES
        private void DrawLogo()
        {
            
        }
        private List<Room> GetRooms()
        {
            List<Room> Rooms = new List<Room>();
            for (int i = 0; i < 20; i++)
            {
                int roomNr = i;
                int size;
                if (i % 3 == 0)
                {
                    size = 2;
                }
                else
                {
                    size = 4;
                }
                Room newRoom = new Room(roomNr, size);
                Rooms.Add(newRoom);
            }
            return Rooms;
        }
        private void btnNewReservation_Click(object sender, RoutedEventArgs e)
        {
            ReservationWindow newReservationWindow = new ReservationWindow(Rooms);
            newReservationWindow.ShowDialog();
            if (newReservationWindow.DialogResult.Value)        
            {
                Booking newBooking = new Booking(newReservationWindow.BookingName, 
                    newReservationWindow.StartDate, newReservationWindow.EndDate, 
                    newReservationWindow.Guests, newReservationWindow.Room);
                Bookings.Add(newBooking);
                dgBookings.ItemsSource = null;
                dgBookings.Items.Clear();
                dgBookings.ItemsSource = Bookings;
                //List<Guest> guests = Bookings.Room;
                //CbbGuests.ItemsSource = guests;

            }
        }
    }
}
