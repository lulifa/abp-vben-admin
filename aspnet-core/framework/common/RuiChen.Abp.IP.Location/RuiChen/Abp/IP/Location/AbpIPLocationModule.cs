﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.IP.Location;

public class AbpIPLocationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddSingleton<ICurrentIPLocationAccessor>(AsyncLocalCurrentIPLocationAccessor.Instance);
    }
}
