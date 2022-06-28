using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TripEF;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args = null)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>();
        options.UseSqlServer("Server=.; Database=TripDatabase; Trusted_Connection=True");
        return new AppDbContext(options.Options);
    }
}