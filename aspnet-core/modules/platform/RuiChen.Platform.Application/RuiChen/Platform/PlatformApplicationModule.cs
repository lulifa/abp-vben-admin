﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace RuiChen.Platform;

[DependsOn(
    typeof(PlatformApplicationContractModule),
    typeof(PlatformDomainModule),
    typeof(AbpDddApplicationModule))]
public class PlatformApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<PlatformApplicationModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<PlatformApplicationModule>(validate: true);
        });
    }
}
