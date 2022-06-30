using System.Windows;
using TripEF;
using TripEF.TripServices;

namespace TripGUI;

public partial class SeaTripUpdate : Window
{
    private readonly SeaTripService _service;
    private int id;
    public SeaTripUpdate(int id)
    {
        InitializeComponent();
        this.id = id;
        _service = new SeaTripService(new AppDbContextFactory());
        GetById(id);
    }
    
    private void GetById(int id)
    {
        var item = _service.GetById(id);
        Name.Text = item.Name;

    }
    private void Update(object sender, RoutedEventArgs e)
    {
        if (Name.Text != null)
        {
            var item = _service.GetById(id);
            item.Name = Name.Text;
            
            _service.Update(item);
            this.Close();
            MessageBox.Show("Edit Sucessfully!");
        }
        else
        {
            MessageBox.Show("Something went wrong!");
        }
    }
}