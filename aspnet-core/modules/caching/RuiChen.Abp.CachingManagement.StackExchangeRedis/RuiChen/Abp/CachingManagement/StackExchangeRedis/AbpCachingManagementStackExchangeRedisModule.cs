﻿using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.CachingManagement.StackExchangeRedis;

[DependsOn(
    typeof(AbpCachingManagementDomainModule),
    typeof(AbpCachingStackExchangeRedisModule))]
public class AbpCachingManagementStackExchangeRedisModule : AbpModule
{
}
