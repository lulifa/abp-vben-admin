using Volo.Abp.Modularity;
using VoloAbpFeatureManagementApplicationModule = Volo.Abp.FeatureManagement.AbpFeatureManagementApplicationModule;

namespace RuiChen.Abp.FeatureManagement;

[DependsOn(
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(VoloAbpFeatureManagementApplicationModule))]
public class AbpFeatureManagementApplicationModule : AbpModule
{
}
