using RuiChen.Abp.DataProtection;
using RuiChen.Abp.Exporter;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace RuiChen.Single;

[DependsOn(
    typeof(AbpDataProtectionAbstractionsModule),
    typeof(AbpExporterApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(RuiChenSingleDomainSharedModule))]
public class RuiChenSingleApplicationContractsModule : AbpModule
{
}
