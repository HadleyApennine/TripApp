using System.ComponentModel.DataAnnotations;

namespace TripEF.Entities;

public class CityBreakTrip 
{
    [Key] public int TripID { get; set; }

    public string Name { get; set; }
}