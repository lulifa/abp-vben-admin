﻿using RuiChen.Platform.Settings.VueVbenAdmin;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace RuiChen.Platform.Theme.VueVbenAdmin;

[DependsOn(
    typeof(PlatformDomainModule),
    typeof(PlatformSettingsVueVbenAdminModule),
    typeof(PlatformApplicationContractModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PlatformThemeVueVbenAdminModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PlatformThemeVueVbenAdminModule).Assembly);
        });
    }
}