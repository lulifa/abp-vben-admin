using RuiChen.Abp.Exporter.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.Exporter;

[DependsOn(typeof(AbpLocalizationModule))]
public class AbpExporterCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpExporterCoreModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpExporterResource>("en")
                .AddVirtualJson("/RuiChen/Abp/Exporter/Localization/Resources");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace(ExporterErrorCodes.Namespace, typeof(AbpExporterResource));
        });
    }
}