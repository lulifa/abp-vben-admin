﻿using RuiChen.Platform;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.UI.Navigation.VueVbenAdmin5;

[DependsOn(
    typeof(AbpUINavigationModule),
    typeof(PlatformDomainModule))]
public class AbpUINavigationVueVbenAdmin5Module : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.NavigationSeedContributors.Add<VueVbenAdmin5NavigationSeedContributor>();
        });
    }
}
