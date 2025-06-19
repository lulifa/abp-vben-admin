using Volo.Abp.ExceptionHandling;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Wrapper;

[DependsOn(typeof(AbpExceptionHandlingModule))]
public class AbpWrapperModule: AbpModule
{

}
