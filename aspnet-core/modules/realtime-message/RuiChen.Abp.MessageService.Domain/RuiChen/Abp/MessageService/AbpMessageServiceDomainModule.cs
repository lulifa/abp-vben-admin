using RuiChen.Abp.IM.Localization;
using RuiChen.Abp.MessageService.Chat;
using RuiChen.Abp.MessageService.Localization;
using RuiChen.Abp.MessageService.Mapper;
using RuiChen.Abp.MessageService.ObjectExtending;
using RuiChen.Abp.Notifications;
using Volo.Abp.AutoMapper;
using Volo.Abp.Caching;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending.Modularity;

namespace RuiChen.Abp.MessageService;

[DependsOn(
    typeof(AbpAutoMapperModule),
    typeof(AbpCachingModule),
    typeof(AbpNotificationsModule),
    typeof(AbpMessageServiceDomainSharedModule))]
public class AbpMessageServiceDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<MessageServiceDomainAutoMapperProfile>(validate: true);
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MessageServiceResource>()
                .AddBaseTypes(typeof(AbpIMResource));
        });
    }

    public override void PostConfigureServices(ServiceConfigurationContext context)
    {
        ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToEntity(
            MessageServiceModuleExtensionConsts.ModuleName,
            MessageServiceModuleExtensionConsts.EntityNames.Message,
            typeof(Message)
        );
    }
}
