using Volo.Abp.Modularity;
using VoloAbpPermissionManagementApplicationModule = Volo.Abp.PermissionManagement.AbpPermissionManagementApplicationModule;

namespace RuiChen.Abp.PermissionManagement;

[DependsOn(
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(VoloAbpPermissionManagementApplicationModule))]
public class AbpPermissionManagementApplicationModule : AbpModule
{

}
