using Microsoft.EntityFrameworkCore;
using RuiChen.Abp.DataProtection.EntityFrameworkCore;

namespace RuiChen.Single.EntityFrameworkCore;

public class SingleDbContext : AbpDataProtectionDbContext<SingleDbContext>
{
    public SingleDbContext(DbContextOptions<SingleDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureSingle(); ;
    }
}
