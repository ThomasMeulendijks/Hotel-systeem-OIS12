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
    /// Interaction logic for CreateGuestWindow.xaml
    /// </summary>
    public partial class CreateGuestWindow : Window
    {
        public Guest Guest { get; set; }
        public CreateGuestWindow()
        {
            InitializeComponent();
        }

        private void btnCreate(object sender, RoutedEventArgs e)
        {
            if (tbGuestName.Text != null && tbGuestAdres.Text != null)
            {
                Guest = new Guest(tbGuestName.Text, tbGuestAdres.Text);
                DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("bad input");
            }
        }
    }
}
