using RuiChen.Abp.Authorization.OrganizationUnits;
using RuiChen.Abp.Authorization.Permissions;
using RuiChen.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace RuiChen.Abp.PermissionManagement.OrganizationUnits;

[DependsOn(
    typeof(AbpIdentityDomainModule),
    typeof(AbpPermissionManagementDomainModule),
    typeof(AbpAuthorizationOrganizationUnitsModule)
    )]
public class AbpPermissionManagementDomainOrganizationUnitsModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<PermissionManagementOptions>(options =>
        {
            options.ManagementProviders.Add<OrganizationUnitPermissionManagementProvider>();

            options.ProviderPolicies[OrganizationUnitPermissionValueProvider.ProviderName] = "AbpIdentity.OrganizationUnits.ManagePermissions";
        });
    }
}
