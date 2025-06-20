using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Identity;

[DependsOn(
    typeof(Volo.Abp.Identity.AbpIdentityApplicationContractsModule),
    typeof(AbpIdentityDomainSharedModule),
    typeof(AbpAuthorizationModule)
    )]
public class AbpIdentityApplicationContractsModule : AbpModule
{
}
