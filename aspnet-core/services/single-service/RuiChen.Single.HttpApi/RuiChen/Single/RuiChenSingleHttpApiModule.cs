using Microsoft.Extensions.DependencyInjection;
using RuiChen.Single.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.Modularity;

namespace RuiChen.Single;

[DependsOn(
    typeof(AbpAspNetCoreMvcModule),
    typeof(RuiChenSingleApplicationContractsModule))]
public class RuiChenSingleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(RuiChenSingleHttpApiModule).Assembly);
        });

        PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(
                typeof(SingleResource),
                typeof(RuiChenSingleApplicationContractsModule).Assembly);
        });
    }
}
