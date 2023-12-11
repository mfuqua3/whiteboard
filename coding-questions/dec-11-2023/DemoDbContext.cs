using EntityConfigurations.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityConfigurations;

public class DemoDbContext : DbContext
{
    public DemoDbContext(DbContextOptions<DemoDbContext> options):base(options)
    {
        
    }
    public DbSet<Holiday> Holidays { get; set; }
    public DbSet<LocationHoliday> LocationHolidays { get; set; }
    public DbSet<MerchantLocation> MerchantLocations { get; set; }
}