﻿using RuiChen.Platform.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Platform;

[DependsOn(
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule),
    typeof(PlatformDomainSharedModule))]
public class PlatformApplicationContractModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PlatformApplicationContractModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PlatformResource>()
                .AddVirtualJson("/RuiChen/Platform/Localization/ApplicationContracts");
        });
    }
}
