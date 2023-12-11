using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EntityConfigurations;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DemoDbContext>
{
    public DemoDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DemoDbContext>();
        optionsBuilder.UseNpgsql("Server=localhost;Database=entity-configuration-demo;User Id=postgres;password=password");
        return new DemoDbContext(optionsBuilder.Options);
    }
}