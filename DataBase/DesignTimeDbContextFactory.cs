using api.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
{
    public ApplicationDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();

        var connectionString = "Host=localhost;Port=5433;Database=finshark;Username=root;Password=123456";
        optionsBuilder.UseNpgsql(connectionString);

        return new ApplicationDBContext(optionsBuilder.Options);
    }
}
