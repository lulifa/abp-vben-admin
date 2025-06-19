﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Exporter.MiniExcel;

[DependsOn(typeof(AbpExporterCoreModule))]
public class AbpExporterMiniExcelModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.Replace(
            ServiceDescriptor.Transient(
                typeof(IExporterProvider), 
                typeof(MiniExcelExporterProvider)));

        context.Services.Replace(
            ServiceDescriptor.Transient(
                typeof(IImporterProvider),
                typeof(MiniExcelImporterProvider)));
    }
}