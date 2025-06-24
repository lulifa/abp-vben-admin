using RuiChen.Abp.OssManagement.Localization;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.OssManagement;

public abstract class OssManagementApplicationServiceBase : ApplicationService
{
    protected OssManagementApplicationServiceBase()
    {
        LocalizationResource = typeof(AbpOssManagementResource);
        ObjectMapperContext = typeof(AbpOssManagementApplicationModule);
    }
}
