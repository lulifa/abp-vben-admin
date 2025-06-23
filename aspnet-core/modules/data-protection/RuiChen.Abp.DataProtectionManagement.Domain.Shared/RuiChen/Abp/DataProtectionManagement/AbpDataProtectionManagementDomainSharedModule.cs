using RuiChen.Abp.DataProtection;
using RuiChen.Abp.DataProtection.Localization;
using Volo.Abp.Domain;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.DataProtectionManagement;

[DependsOn(typeof(AbpDddDomainSharedModule))]
[DependsOn(typeof(AbpDataProtectionAbstractionsModule))]
public class AbpDataProtectionManagementDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpDataProtectionManagementDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DataProtectionResource>()
                .AddVirtualJson("/RuiChen/Abp/DataProtectionManagement/Localization/Resources");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace(DataProtectionManagementErrorCodes.Namespace, typeof(DataProtectionResource));
        });
    }
}
