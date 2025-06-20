using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Exporter;

[DependsOn(
    typeof(AbpDddApplicationModule),
    typeof(AbpExporterCoreModule),
    typeof(AbpExporterApplicationContractsModule))]
public class AbpExporterApplicationModule : AbpModule
{
}
