using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TripEF;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    /// <summary>
    /// Tworzenie AppDbContext przez fabryke
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public AppDbContext CreateDbContext(string[] args = null)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>();
        options.UseSqlServer("Server=.; Database=TripDatabase; Trusted_Connection=True");
        return new AppDbContext(options.Options);
    }
}