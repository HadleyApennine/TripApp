using System.Windows;
using System.Windows.Controls;
using TripEF;
using TripEF.TripServices;

namespace TripGUI.Views;

public partial class FestivalTripView : UserControl
{
    private readonly FestivalTripService _service;
    public FestivalTripView()
    {
        InitializeComponent();
        _service = new FestivalTripService(new AppDbContextFactory());
        Get();
    }

    public  void Get()
    {
        var items =  _service.GetAll();
        FestivalTripDynamic.ItemsSource = items;
    }
    
    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        dynamic content = ((Button)sender).DataContext;
        _service.Remove(content.TripID);
        Get();
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