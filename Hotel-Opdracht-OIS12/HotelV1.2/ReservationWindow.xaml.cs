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
using System.Windows.Shapes;
using Hotel;

namespace HotelV1._2
{
    /// <summary>
    /// Interaction logic for ReservationWindow.xaml
    /// </summary>
    public partial class ReservationWindow : Window
    {
        // PUBLIC PROPERTIES
        public string BookingName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Guest> Guests { get; set; }
        public Room Room { get; set; }

        // CONSTRUCTOR
        public ReservationWindow(List<Room> rooms)
        {
            InitializeComponent();
            Guests = new List<Guest>();
            cbbRoom.ItemsSource = rooms;
        }
        // METHODES

        /// <summary>
        /// 
        /// </summary>

        private void btnSubmit(object sender, RoutedEventArgs e)
        {
            if (tbBookingName.Text.Length > 0)
            {
                if((dateStart.IsInitialized && dateEnd.IsInitialized)&&((dateStart.DisplayDate < dateEnd.DisplayDate) || (dateStart.DisplayDate == dateEnd.DisplayDate)))
                {
                    if (cbbRoom.SelectedIndex > -1)
                    {
                        if (Guests.Count > 0)
                        {
                            // Sets all data
                            BookingName = tbBookingName.Text;
                            StartDate = dateStart.DisplayDate;
                            EndDate = dateEnd.DisplayDate;
                            Room = (Room)cbbRoom.SelectedItem;
                            DialogResult = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Add a guest");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a room");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong date");
                }
            }
            else
            {
                MessageBox.Show("Reserviringsnaam niet correct");
            }


        }
        
        /// <summary>
        /// 
        /// </summary>
        private void btnAddGuest(object sender, RoutedEventArgs e)
        {
            CreateGuestWindow newGuestWindow = new CreateGuestWindow();
            newGuestWindow.ShowDialog();
            if (newGuestWindow.DialogResult.Value)
            {
                
                Guests.Add(newGuestWindow.Guest);
                lbGuests.ItemsSource = null;
                lbGuests.ItemsSource = Guests;
            }
        }
    }
}
