using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.DataProtectionManagement;

[DependsOn(
    typeof(AbpAuthorizationAbstractionsModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpDataProtectionManagementDomainSharedModule))]
public class AbpDataProtectionManagementApplicationContractsModule : AbpModule
{

}
