using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.LocalizationManagement;

[DependsOn(
    typeof(AbpAuthorizationModule),
    typeof(AbpLocalizationManagementDomainSharedModule))]
public class AbpLocalizationManagementApplicationContractsModule : AbpModule
{

}
