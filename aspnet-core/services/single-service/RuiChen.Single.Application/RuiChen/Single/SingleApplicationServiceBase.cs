using Volo.Abp.Application.Services;

namespace RuiChen.Single;
public abstract class SingleApplicationServiceBase : ApplicationService
{
    protected SingleApplicationServiceBase()
    {
        LocalizationResource = typeof(RuiChenSingleApplicationModule);
        ObjectMapperContext = typeof(RuiChenSingleApplicationModule);
    }
}
