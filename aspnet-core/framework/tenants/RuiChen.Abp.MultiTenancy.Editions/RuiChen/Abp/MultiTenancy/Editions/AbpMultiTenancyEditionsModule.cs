using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace RuiChen.Abp.MultiTenancy.Editions;

[DependsOn(typeof(AbpMultiTenancyModule))]
public class AbpMultiTenancyEditionsModule : AbpModule
{
}
