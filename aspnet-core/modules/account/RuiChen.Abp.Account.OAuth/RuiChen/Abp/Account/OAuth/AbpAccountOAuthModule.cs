using RuiChen.Abp.Account.OAuth.Localization;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.Account.OAuth;

[DependsOn(typeof(AbpFeaturesModule))]
[DependsOn(typeof(AbpSettingsModule))]
public class AbpAccountOAuthModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpAccountOAuthModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AccountOAuthResource>()
                .AddVirtualJson("/RuiChen/Abp/Account/OAuth/Localization/Resources");
        });
    }
}
