using RuiChen.Abp.Saas.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RuiChen.Abp.Saas;
public abstract class AbpSaasControllerBase : AbpControllerBase
{
    protected AbpSaasControllerBase()
    {
        LocalizationResource = typeof(AbpSaasResource);
    }
}
