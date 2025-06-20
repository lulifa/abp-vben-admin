using RC.MicroService.Single.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace RC.MicroService.Single.DbMigrator;

[DependsOn(
    //typeof(AbpUINavigationVueVbenAdminModule),
    typeof(SingleMigrationEntityFrameworkCoreModule),
    typeof(AbpAutofacModule)
    )]
public partial class SingleDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
    }
}
