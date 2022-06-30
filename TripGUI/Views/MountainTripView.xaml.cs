using System.Windows;
using System.Windows.Controls;
using TripEF;
using TripEF.Entities;
using TripEF.TripServices;

namespace TripGUI.Views;

public partial class MountainTripView : UserControl
{
    private readonly MountainTripService _service;
    public MountainTripView()
    {
        InitializeComponent();
        _service = new MountainTripService(new AppDbContextFactory());
        Get();
    }

    public  void Get()
    {
        var items =  _service.GetAll();
        MountainTripDynamic.ItemsSource = items;
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
        Window window = new MountainTripUpdate(content.TripID);
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
            _service.AddAsync(new MountainTrip(){Name=Name.Text});
            Name.Text = "";
            Get();
            MessageBox.Show("Added successfully!");
        }
    }
}