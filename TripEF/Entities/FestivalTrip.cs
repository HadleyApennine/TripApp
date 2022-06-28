using System.ComponentModel.DataAnnotations;

namespace TripEF.Entities;

public class FestivalTrip
{
    [Key] public int TripID { get; set; }
    public string Name { get; set; }
}