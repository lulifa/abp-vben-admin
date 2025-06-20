using RuiChen.Abp.DataProtection;
using RuiChen.Abp.Exporter;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace RuiChen.Single;

[DependsOn(
    typeof(AbpDddApplicationModule),
    typeof(AbpDataProtectionModule),
    typeof(RuiChenSingleDomainModule),
    typeof(AbpExporterApplicationModule),
    typeof(RuiChenSingleApplicationContractsModule))]
public class SingleApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<SingleApplicationModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<SingleApplicationMapperProfile>(validate: true);
        });
    }
}
