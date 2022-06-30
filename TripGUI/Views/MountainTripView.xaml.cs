using System.Windows;
using System.Windows.Controls;
using TripEF;
using TripEF.TripServices;

namespace TripGUI.Views;

public partial class MountainTripView : UserControl
{
    private readonly MountainTripService _service;
    public MountainTripView()
    {
        InitializeComponent();
        _service = new MountainTripService(new AppDbContextFactory());
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
        throw new System.NotImplementedException();
    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        Get();
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}