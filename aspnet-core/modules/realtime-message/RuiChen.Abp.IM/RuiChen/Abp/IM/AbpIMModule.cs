using RuiChen.Abp.IM.Localization;
using RuiChen.Abp.RealTime;
using RuiChen.Abp.IdGenerator;
using Volo.Abp.EventBus;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.IM;

[DependsOn(
    typeof(AbpEventBusModule),
    typeof(AbpRealTimeModule),
    typeof(AbpLocalizationModule),
    typeof(AbpIdGeneratorModule))]
public class AbpIMModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpIMModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpIMResource>()
                .AddVirtualJson("/RuiChen/Abp/IM/Localization/Resources");
        });
    }
}
