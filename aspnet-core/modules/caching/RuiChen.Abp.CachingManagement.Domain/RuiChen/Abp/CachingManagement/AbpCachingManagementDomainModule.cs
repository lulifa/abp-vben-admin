﻿using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.CachingManagement;

[DependsOn(
    typeof(AbpCachingModule))]
public class AbpCachingManagementDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options =>
        {

        });
    }
}
