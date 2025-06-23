using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.CachingManagement;

[DependsOn(
    typeof(AbpCachingManagementApplicationContractsModule),
    typeof(AbpDddApplicationModule))]
public class AbpCachingManagementApplicationModule : AbpModule
{

}