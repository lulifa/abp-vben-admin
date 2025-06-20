using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RC.MicroService.Single.EntityFrameworkCore;

public class SingleMigrationDbContextFactory : IDesignTimeDbContextFactory<SingleMigrationDbContext>
{

    public SingleMigrationDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        var connectionString = configuration.GetConnectionString("Default");

        var builder = new DbContextOptionsBuilder<SingleMigrationDbContext>()
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new SingleMigrationDbContext(builder!.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../RC.MicroService.Single.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }

}
