using RuiChen.Abp.Notifications.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Users;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.Notifications;

[DependsOn(
    typeof(AbpNotificationsCoreModule),
    typeof(AbpUsersDomainSharedModule))]
public class AbpNotificationsDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpNotificationsDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<NotificationsResource>()
                .AddVirtualJson("/RuiChen/Abp/Notifications/Localization/DomainShared");
        });
    }
}
