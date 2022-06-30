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
using TripGUI.Views;

namespace TripGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SeaTrips_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SeaTripView();
        }

        private void CityBreakTrip_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CityBreakTripView();
        }

        private void FestivalTrip_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new FestivalTripView();
        }

        private void MountainTrip_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MountainTripView();
        }
    }
}