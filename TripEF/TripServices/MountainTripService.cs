using TripEF.Entities;
using TripEF.Services;

namespace TripEF.TripServices;

public class MountainTripService:EntityBaseService<MountainTrip>, IMountainTripService
{
    public MountainTripService(AppDbContextFactory context) : base(context)
    {
    }
}