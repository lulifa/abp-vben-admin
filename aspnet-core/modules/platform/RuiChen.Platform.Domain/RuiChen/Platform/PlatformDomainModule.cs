﻿using RuiChen.Platform.Datas;
using RuiChen.Platform.Layouts;
using RuiChen.Platform.Menus;
using RuiChen.Platform.Messages;
using RuiChen.Platform.ObjectExtending;
using RuiChen.Platform.Packages;
using RuiChen.Platform.Routes;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.BlobStoring;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.Emailing;
using Volo.Abp.EventBus;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending.Modularity;
using Volo.Abp.Sms;
using SmsMessage = RuiChen.Platform.Messages.SmsMessage;

namespace RuiChen.Platform;

[DependsOn(
    typeof(AbpSmsModule),
    typeof(AbpEmailingModule),
    typeof(AbpEventBusModule),
    typeof(AbpBlobStoringModule),
    typeof(PlatformDomainSharedModule))]
public class PlatformDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<PlatformDomainModule>();

        Configure<DataItemMappingOptions>(options =>
        {
            options.SetDefaultMapping();
        });

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<PlatformDomainMappingProfile>(validate: true);
        });

        Configure<AbpBlobStoringOptions>(options =>
        {
            options.Containers.Configure<PackageContainer>(containerConfiguration =>
            {
                containerConfiguration.IsMultiTenant = true;
            });
        });

        Configure<AbpDistributedEntityEventOptions>(options =>
        {
            options.EtoMappings.Add<Layout, LayoutEto>(typeof(PlatformDomainModule));

            options.EtoMappings.Add<Menu, MenuEto>(typeof(PlatformDomainModule));
            options.EtoMappings.Add<UserMenu, UserMenuEto>(typeof(PlatformDomainModule));
            options.EtoMappings.Add<RoleMenu, RoleMenuEto>(typeof(PlatformDomainModule));

            options.EtoMappings.Add<Package, PackageEto>(typeof(PlatformDomainModule));

            options.EtoMappings.Add<EmailMessage, EmailMessageEto>(typeof(PlatformDomainModule));
            options.EtoMappings.Add<SmsMessage, SmsMessageEto>(typeof(PlatformDomainModule));

            options.AutoEventSelectors.Add<EmailMessage>();
            options.AutoEventSelectors.Add<SmsMessage>();
        });
    }
    public override void PostConfigureServices(ServiceConfigurationContext context)
    {
        ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToEntity(
            PlatformModuleExtensionConsts.ModuleName,
            PlatformModuleExtensionConsts.EntityNames.Route,
            typeof(Route)
        );
        ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToEntity(
            PlatformModuleExtensionConsts.ModuleName,
            PlatformModuleExtensionConsts.EntityNames.Package,
            typeof(Package)
        );
    }
}
