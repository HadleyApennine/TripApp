using TripEF.Entities;
using TripEF.Services;

namespace TripEF.TripServices;

public class CityBreakTripService:EntityBaseService<CityBreakTrip>, ICityBreakTripService
{
    public CityBreakTripService(AppDbContextFactory context) : base(context)
    {
    }
}