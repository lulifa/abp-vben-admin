using RuiChen.Abp.DataProtection.Localization;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.ObjectExtending;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.DataProtection;

[DependsOn(typeof(AbpLocalizationModule))]
[DependsOn(typeof(AbpMultiTenancyModule))]
[DependsOn(typeof(AbpObjectExtendingModule))]
public class AbpDataProtectionAbstractionsModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddSingleton<ICurrentDataAccessAccessor>(AsyncLocalCurrentDataAccessAccessor.Instance);

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpDataProtectionAbstractionsModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<DataProtectionResource>()
                .AddVirtualJson("/RuiChen/Abp/DataProtection/Localization/Resources");
        });
    }
}
