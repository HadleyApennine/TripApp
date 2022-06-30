using System.ComponentModel.DataAnnotations;
using TripEF.Services;

namespace TripEF.Entities;
/// <summary>
/// Klasa dla przedmiotow na wycieczke
/// </summary>
public class MountainTrip : IEntityBase
{
    [Key] public int TripID { get; set; }
    public string Name { get; set; }
}