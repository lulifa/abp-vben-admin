using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Identity.Session;

[DependsOn(typeof(AbpCachingModule))]
public class AbpIdentitySessionModule : AbpModule
{
}
