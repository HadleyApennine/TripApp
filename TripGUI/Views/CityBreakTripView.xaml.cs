using System.Windows;
using System.Windows.Controls;
using TripEF;
using TripEF.Entities;
using TripEF.TripServices;

namespace TripGUI.Views;

public partial class CityBreakTripView : UserControl
{
    private readonly CityBreakTripService _service;
    public CityBreakTripView()
    {
        InitializeComponent();
        _service = new CityBreakTripService(new AppDbContextFactory());
        Get();
    }


    public void Get()
    {
        var items =  _service.GetAll();
        CityBreakTripDynamic.ItemsSource = items;
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        dynamic content = ((Button)sender).DataContext;
        _service.Remove(content.TripID);
        Get();
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
        dynamic content = ((Button)sender).DataContext;
        Window window = new CityBreakTripUpdate(content.TripID);
        window.Show();
        

    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        Get();
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        if (Name.Text != null)
        {
            _service.AddAsync(new CityBreakTrip(){Name=Name.Text});
            Name.Text = "";
            Get();
            MessageBox.Show("Added successfully!");
        }
        
    }
}