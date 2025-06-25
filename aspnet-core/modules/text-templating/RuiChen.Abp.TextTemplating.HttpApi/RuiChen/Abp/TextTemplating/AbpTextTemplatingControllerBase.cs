using RuiChen.Abp.TextTemplating.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RuiChen.Abp.TextTemplating;

public abstract class AbpTextTemplatingControllerBase : AbpControllerBase
{
    protected AbpTextTemplatingControllerBase()
    {
        LocalizationResource = typeof(AbpTextTemplatingResource);
    }
}
