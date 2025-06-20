using Microsoft.Extensions.DependencyInjection;
using RuiChen.Abp.DataProtection.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RuiChen.Single.EntityFrameworkCore;

[DependsOn(
    typeof(RuiChenSingleDomainModule),
    typeof(AbpDataProtectionEntityFrameworkCoreModule))]
public class RuiChenSingleEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<SingleDbContext>(options =>
        {
            options.AddDefaultRepositories();
        });
    }
}
