﻿using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.MessageService;

[DependsOn(
    typeof(AbpMessageServiceApplicationContractsModule),
    typeof(AbpMessageServiceDomainModule))]
public class AbpMessageServiceApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<AbpMessageServiceApplicationAutoMapperProfile>(validate: true);
        });
    }
}
