using Microsoft.EntityFrameworkCore;
using TripEF.Entities;

namespace TripEF;

public class AppDbContext : DbContext
{
    public DbSet<SeaTrip> SeaTrips { get; set; }
    public DbSet<CityBreakTrip> CityBreakTrips { get; set; }
    public DbSet<FestivalTrip> FestivalTrips { get; set; }
    public DbSet<MountainTrip> MountainTrips { get; set; }


    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CityBreakTrip>().HasKey(e => e.TripID);
        modelBuilder.Entity<FestivalTrip>().HasKey(e => e.TripID);
        modelBuilder.Entity<MountainTrip>().HasKey(e => e.TripID);
        modelBuilder.Entity<SeaTrip>().HasKey(e => e.TripID);
    }
}