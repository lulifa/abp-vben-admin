using RuiChen.Abp.EntityChange.Localization;
using Volo.Abp.Application;
using Volo.Abp.Auditing;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.EntityChange;

[DependsOn(
    typeof(AbpAuditingModule),
    typeof(AbpDddApplicationContractsModule))]
public class AbpEntityChangeApplicationContractsModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpEntityChangeApplicationContractsModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpEntityChangeResource>()
                .AddVirtualJson("/RuiChen/Abp/EntityChange/Localization/Resources");
        });
    }
}
