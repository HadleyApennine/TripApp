using System.Windows;
using System.Windows.Controls;
using TripEF;
using TripEF.TripServices;

namespace TripGUI.Views;

public partial class SeaTripView : UserControl
{
    private readonly SeaTripService _service;
    public SeaTripView()
    {
        InitializeComponent();
        _service = new SeaTripService(new AppDbContextFactory());
        Get();
    }

    public  void Get()
    {
        var items =  _service.GetAll();
        SeaTripDynamic.ItemsSource = items;
    }
    
    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
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