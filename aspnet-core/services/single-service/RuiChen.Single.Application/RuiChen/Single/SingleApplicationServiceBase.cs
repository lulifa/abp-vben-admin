using Volo.Abp.Application.Services;

namespace RuiChen.Single;
public abstract class SingleApplicationServiceBase : ApplicationService
{
    protected SingleApplicationServiceBase()
    {
        LocalizationResource = typeof(SingleApplicationModule);
        ObjectMapperContext = typeof(SingleApplicationModule);
    }
}
