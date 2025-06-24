using RuiChen.Abp.Notifications;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Identity.Notifications;

[DependsOn(
    typeof(AbpNotificationsModule),
    typeof(AbpDddDomainSharedModule),
    typeof(AbpIdentityDomainSharedModule))]
public class AbpIdentityNotificationsModule : AbpModule
{

}
