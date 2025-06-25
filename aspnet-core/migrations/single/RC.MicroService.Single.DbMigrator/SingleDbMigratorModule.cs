using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RC.MicroService.Single.EntityFrameworkCore;
using RuiChen.Abp.UI.Navigation.VueVbenAdmin5;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Timing;

namespace RC.MicroService.Single.DbMigrator;

[DependsOn(
    typeof(AbpUINavigationVueVbenAdmin5Module),
    typeof(SingleMigrationEntityFrameworkCoreModule),
    typeof(AbpAutofacModule)
    )]
public class SingleDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        Configure<AbpClockOptions>(options =>
        {
            configuration.GetSection("Clock").Bind(options);
        });
    }
}
