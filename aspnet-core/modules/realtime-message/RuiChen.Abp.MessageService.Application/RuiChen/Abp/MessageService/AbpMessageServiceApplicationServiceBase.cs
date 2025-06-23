using RuiChen.Abp.MessageService.Localization;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.MessageService;

public abstract class AbpMessageServiceApplicationServiceBase : ApplicationService
{
    protected AbpMessageServiceApplicationServiceBase()
    {
        LocalizationResource = typeof(MessageServiceResource);
        ObjectMapperContext = typeof(AbpMessageServiceApplicationModule);
    }
}
