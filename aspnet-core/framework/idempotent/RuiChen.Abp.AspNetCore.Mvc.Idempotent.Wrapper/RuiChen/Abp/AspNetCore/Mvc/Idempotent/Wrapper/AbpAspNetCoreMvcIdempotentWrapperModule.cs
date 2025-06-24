using RuiChen.Abp.AspNetCore.Wrapper;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.AspNetCore.Mvc.Idempotent.Wrapper;

[DependsOn(
    typeof(AbpAspNetCoreWrapperModule),
    typeof(AbpAspNetCoreMvcIdempotentModule))]
public class AbpAspNetCoreMvcIdempotentWrapperModule : AbpModule
{

}
