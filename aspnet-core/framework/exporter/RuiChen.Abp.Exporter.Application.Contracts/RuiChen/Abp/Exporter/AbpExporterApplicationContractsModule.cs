using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Exporter;

[DependsOn(typeof(AbpDddApplicationContractsModule))]
public class AbpExporterApplicationContractsModule : AbpModule
{
}
