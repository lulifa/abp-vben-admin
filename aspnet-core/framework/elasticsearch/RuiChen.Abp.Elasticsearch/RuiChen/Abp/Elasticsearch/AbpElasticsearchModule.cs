﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Elasticsearch
{
    public class AbpElasticsearchModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            Configure<AbpElasticsearchOptions>(configuration.GetSection("Elasticsearch"));
        }
    }
}
