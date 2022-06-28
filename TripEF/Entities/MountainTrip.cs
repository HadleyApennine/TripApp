using System.ComponentModel.DataAnnotations;
using TripEF.Services;

namespace TripEF.Entities;

public class MountainTrip : IEntityBase
{
    [Key] public int TripID { get; set; }
    public string Name { get; set; }
}