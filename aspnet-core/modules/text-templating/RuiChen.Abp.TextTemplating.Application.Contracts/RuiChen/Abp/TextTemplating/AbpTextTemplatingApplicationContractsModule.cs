using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.TextTemplating;

[DependsOn(
    typeof(AbpTextTemplatingDomainSharedModule),
    typeof(AbpAuthorizationAbstractionsModule),
    typeof(AbpDddApplicationContractsModule))]
public class AbpTextTemplatingApplicationContractsModule : AbpModule
{

}
