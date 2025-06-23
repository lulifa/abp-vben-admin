using RuiChen.Abp.LocalizationManagement.Localization;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.LocalizationManagement;

public abstract class LocalizationAppServiceBase : ApplicationService
{
    protected LocalizationAppServiceBase()
    {
        LocalizationResource = typeof(LocalizationManagementResource);
        ObjectMapperContext = typeof(AbpLocalizationManagementApplicationModule);
    }
}
