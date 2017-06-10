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

namespace HotelV1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            logo();
        }

        private void logo()
        {
            // Create a red Ellipse.
            Ellipse myEllipse = new Ellipse();

            // Create a SolidColorBrush with a red color to fill the 
            // Ellipse with.
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values. 
            // Each value has a range of 0-255.
            mySolidColorBrush.Color = Color.FromArgb(100, 76, 176, 80);
            myEllipse.Fill = mySolidColorBrush;


            // Set the width and height of the Ellipse.
            myEllipse.Width = 50;
            myEllipse.Height = 50;

            // Add the Ellipse to the StackPanel.
            StackPanel.Children.Add(myEllipse);

            // Add a Line Element
            Line myLine = new Line();
            myLine.Stroke = Brushes.Black;
            myLine.X1 = 0;
            myLine.X2 = 50;
            myLine.Y1 = 25;
            myLine.Y2 = 25;
            //myLine.HorizontalAlignment = HorizontalAlignment.Left;
            //myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 4;
            StackPanel.Children.Add(myLine);
        }

        private void btnDatabase_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
