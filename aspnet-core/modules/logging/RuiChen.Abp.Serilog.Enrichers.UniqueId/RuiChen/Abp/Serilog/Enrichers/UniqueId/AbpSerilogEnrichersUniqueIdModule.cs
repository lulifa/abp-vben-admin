using RuiChen.Abp.IdGenerator;
using RuiChen.Abp.IdGenerator.Snowflake;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Serilog.Enrichers.UniqueId;

[DependsOn(typeof(AbpIdGeneratorModule))]
public class AbpSerilogEnrichersUniqueIdModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var options = context.Services.ExecutePreConfiguredActions<AbpSerilogEnrichersUniqueIdOptions>();
        UniqueIdEnricher.DistributedIdGenerator = SnowflakeIdGenerator.Create(options.SnowflakeIdOptions);
    }
}
