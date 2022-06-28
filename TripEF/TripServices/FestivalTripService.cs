using TripEF.Entities;
using TripEF.Services;

namespace TripEF.TripServices;

public class FestivalTripService:EntityBaseService<FestivalTrip>, IFestivalTripService
{
    public FestivalTripService(AppDbContextFactory context) : base(context)
    {
    }
}