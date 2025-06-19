using Volo.Abp.Modularity;

namespace RuiChen.Abp.Features.LimitValidation.Redis.Client;

[DependsOn(typeof(AbpFeaturesValidationRedisModule))]
public class AbpFeaturesValidationRedisClientModule : AbpModule
{
}
