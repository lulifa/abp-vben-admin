using RuiChen.Abp.Wrapper;
using Volo.Abp.AspNetCore;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.AspNetCore.Wrapper;

[DependsOn(
    typeof(AbpWrapperModule),
    typeof(AbpAspNetCoreModule))]
public class AbpAspNetCoreWrapperModule : AbpModule
{

}
