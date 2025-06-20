using RuiChen.Single.Localization;
using Volo.Abp.Domain;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Single;

[DependsOn(typeof(AbpDddDomainSharedModule))]
public class RuiChenSingleDomainSharedModule : AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<RuiChenSingleDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<SingleResource>("en")
                .AddVirtualJson("/RuiChen/Single/Localization/Resources");
        });
        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace(SingleErrorCodes.Namespace, typeof(SingleResource));
        });
    }

}
