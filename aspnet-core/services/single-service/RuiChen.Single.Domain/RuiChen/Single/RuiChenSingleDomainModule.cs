using Volo.Abp.AutoMapper;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace RuiChen.Single;

[DependsOn(
    typeof(AbpAutoMapperModule),
    typeof(AbpDddDomainModule),
    typeof(RuiChenSingleDomainSharedModule))]
public class RuiChenSingleDomainModule : AbpModule
{
}
