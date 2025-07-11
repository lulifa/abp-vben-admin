﻿using RuiChen.Abp.AspNetCore.Mvc.Wrapper.Filters;
using RuiChen.Abp.AspNetCore.Mvc.Wrapper.Localization;
using RuiChen.Abp.AspNetCore.Wrapper;
using RuiChen.Abp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ApiExploring;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;
using Volo.Abp.AspNetCore.Mvc.ProxyScripting;
using Volo.Abp.Content;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RuiChen.Abp.AspNetCore.Mvc.Wrapper;

[DependsOn(
    typeof(AbpWrapperModule),
    typeof(AbpAspNetCoreWrapperModule))]
public class AbpAspNetCoreMvcWrapperModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpAspNetCoreMvcWrapperModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpMvcWrapperResource>("en")
                .AddVirtualJson("/RuiChen/Abp/AspNetCore/Mvc/Wrapper/Localization/Resources");
        });

        Configure<MvcOptions>(mvcOptions =>
        {
            // Wrap Result Filter
            mvcOptions.Filters.AddService(typeof(AbpWrapResultFilter));
        });

        Configure<AbpWrapperOptions>(options =>
        {
            // 即使重写端点也不包装返回结果
            // api/abp/api-definition
            // options.IgnoreReturnTypes.Add<ApplicationApiDescriptionModel>();
            // api/abp/application-configuration
            //  options.IgnoreReturnTypes.Add<ApplicationConfigurationDto>();
            // api/abp/application-localization
            // options.IgnoreReturnTypes.Add<ApplicationLocalizationDto>(); 
            // 文件流
            options.IgnoreReturnTypes.Add<IRemoteStreamContent>();
            // options.IgnoreReturnTypes.Add<FileResult>();

            //options.IgnoreReturnTypes.Add<ViewResult>();
            //options.IgnoreReturnTypes.Add<ViewEngineResult>();
            //options.IgnoreReturnTypes.Add<ViewComponentResult>();

            //options.IgnoreReturnTypes.Add<RedirectToActionResult>();
            //options.IgnoreReturnTypes.Add<RedirectToPageResult>();
            //options.IgnoreReturnTypes.Add<RedirectToRouteResult>();

            //options.IgnoreReturnTypes.Add<SignInResult>();
            //options.IgnoreReturnTypes.Add<SignOutResult>();
            //options.IgnoreReturnTypes.Add<ForbidResult>();

            // options.IgnoreControllers.Add<AbpApplicationLocalizationController>();
            // options.IgnoreControllers.Add<AbpApplicationConfigurationController>();

            // Api Endpoints
            options.IgnoreControllers.Add<AbpApiDefinitionController>();
            // Abp/ServiceProxyScript
            options.IgnoreControllers.Add<AbpServiceProxyScriptController>();
            // Application Configuration Script
            options.IgnoreControllers.Add<AbpApplicationConfigurationScriptController>();

            // 官方模块不包装结果
            // options.IgnoreNamespaces.Add("Volo.Abp");

            // oidc端点不包装结果
            options.IgnorePrefixUrls.Add("/connect");

            // 返回本地化的 404 错误消息
            options.MessageWithEmptyResult = (serviceProvider) =>
            {
                var localizer = serviceProvider.GetRequiredService<IStringLocalizer<AbpMvcWrapperResource>>();
                return localizer["Wrapper:NotFound"];
            };
        });
    }
}
