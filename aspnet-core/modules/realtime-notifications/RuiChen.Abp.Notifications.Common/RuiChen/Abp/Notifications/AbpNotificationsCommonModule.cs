using RuiChen.Abp.Notifications.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.Notifications.Common;

[DependsOn(
    typeof(AbpNotificationsModule))]
public class AbpNotificationsCommonModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpNotificationsCommonModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<NotificationsResource>()
                .AddVirtualJson("/RuiChen/Abp/Notifications/Localization/Common");
        });
    }
}
