using TripEF.Entities;
using TripEF.Services;

namespace TripEF.TripServices;

public class SeaTripService:EntityBaseService<SeaTrip>, ISeaTripService
{
    public SeaTripService(AppDbContextFactory context) : base(context)
    {
    }
}