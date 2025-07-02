
using RuiChen.Abp.IP2Region;

namespace RuiChen.Single.HttpApi.Host;

[DependsOn(
    typeof(AbpAccountHttpApiModule),// 账户模块 控制器
    typeof(AbpAccountApplicationModule),// 账户模块 应用服务
    typeof(AbpAccountWebOpenIddictModule),// 账户模块 OpenIddict集成
    typeof(AbpAccountWebOAuthModule),// 账户模块 OAuth集成

    typeof(AbpAuditingHttpApiModule),// 审计日志模块 控制器
    typeof(AbpAuditingApplicationModule),// 审计日志模块 应用服务
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),// 审计日志模块 实体框架
    typeof(AbpAuditLoggingIPLocationModule),// 审计日志模块 IP 地址定位

    typeof(AbpCachingManagementHttpApiModule),// 缓存管理模块 控制器
    typeof(AbpCachingManagementApplicationModule),// 缓存管理模块 应用服务
    typeof(AbpCachingManagementStackExchangeRedisModule),// 缓存管理模块 Redis集成

    typeof(AbpDataProtectionManagementHttpApiModule),// 数据审计模块 控制器
    typeof(AbpDataProtectionManagementApplicationModule),// 数据审计模块 应用服务
    typeof(AbpDataProtectionManagementEntityFrameworkCoreModule),// 数据审计模块 实体框架

    typeof(RuiChen.Abp.FeatureManagement.AbpFeatureManagementHttpApiModule),// 功能管理模块 控制器
    typeof(RuiChen.Abp.FeatureManagement.AbpFeatureManagementApplicationModule),// 功能管理模块 应用服务
    typeof(AbpFeatureManagementEntityFrameworkCoreModule),// 功能管理模块 实体框架

    typeof(AbpIdentityHttpApiModule),// 身份认证模块 控制器
    typeof(AbpIdentityApplicationModule),// 身份认证模块 应用服务
    typeof(AbpIdentityEntityFrameworkCoreModule),// 身份认证模块 实体框架
    typeof(AbpIdentityAspNetCoreSessionModule),// 身份认证模块 会话管理集成
    typeof(AbpIdentitySessionAspNetCoreModule),// 身份认证模块 会话中间件
    typeof(AbpIdentityNotificationsModule),// 身份认证模块 通知集成
    typeof(AbpIdentityOrganizaztionUnitsModule),// 身份认证模块 组织机构集成

    typeof(AbpLocalizationManagementHttpApiModule),// 多语言管理模块 控制器
    typeof(AbpLocalizationManagementApplicationModule),// 多语言管理模块 应用服务
    typeof(AbpLocalizationManagementEntityFrameworkCoreModule),// 多语言管理模块 实体框架

    typeof(AbpOpenIddictHttpApiModule),// OpenIddict扩展模块 控制器
    typeof(AbpOpenIddictApplicationModule),// OpenIddict扩展模块 应用服务
    typeof(AbpOpenIddictEntityFrameworkCoreModule),// OpenIddict扩展模块 实体框架                                
    typeof(AbpOpenIddictAspNetCoreSessionModule),// OpenIddict扩展模块 会话
    typeof(AbpOpenIddictLinkUserModule),// OpenIddict扩展模块 用户链接
    typeof(AbpOpenIddictSmsModule),// OpenIddict扩展模块 短信认证
    typeof(AbpOpenIddictPortalModule),// OpenIddict扩展模块 平台认证
    typeof(AbpOpenIddictQrCodeModule),// OpenIddict扩展模块 扫码登录

    typeof(AbpOssManagementHttpApiModule),// 对象存储模块 控制器
    typeof(AbpOssManagementApplicationModule),// 对象存储模块 应用服务
    typeof(AbpOssManagementFileSystemModule),// 对象存储模块 文件系统
    typeof(AbpOssManagementImagingModule),// 对象存储模块 图片处理
    typeof(AbpOssManagementSettingManagementModule),// 对象存储模块 设置管理

    typeof(AbpPermissionManagementHttpApiModule),// 权限管理模块 控制器
    typeof(AbpPermissionManagementApplicationModule),// 权限管理模块 应用服务
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),// 权限管理模块 实体框架
    typeof(AbpPermissionManagementDomainIdentityModule),// 权限管理模块 身份认证集成
    typeof(AbpPermissionManagementDomainOpenIddictModule),// 权限管理模块 OpenIddict集成
    typeof(AbpPermissionManagementDomainOrganizationUnitsModule),// 权限管理模块 组织机构集成

    typeof(PlatformHttpApiModule),// 平台模块 控制器
    typeof(PlatformApplicationModule),// 平台模块 应用服务
    typeof(PlatformEntityFrameworkCoreModule),// 平台模块 实体框架
    typeof(PlatformSettingsVueVbenAdminModule),// 平台模块 VueVbenAdmin设置
    typeof(PlatformThemeVueVbenAdminModule),// 平台模块 VueVbenAdmin主题
    typeof(AbpUINavigationVueVbenAdmin5Module),// 平台模块 Vben5路由

    typeof(AbpMessageServiceHttpApiModule),// 消息模块 控制器
    typeof(AbpMessageServiceApplicationModule),// 消息模块 应用服务
    typeof(AbpMessageServiceEntityFrameworkCoreModule),// 消息模块 实体框架
    typeof(AbpIMSignalRModule),// 消息模块 实时通知

    typeof(AbpNotificationsHttpApiModule),// 通知模块 控制器
    typeof(AbpNotificationsApplicationModule),// 通知模块 应用服务
    typeof(AbpNotificationsEntityFrameworkCoreModule),// 通知模块 实体框架
    typeof(AbpNotificationsCommonModule),// 通知模块 默认通知
    typeof(AbpNotificationsSignalRModule),// 通知模块 实时通知
    typeof(AbpNotificationsEmailingModule),// 通知模块 邮件通知
    typeof(AbpNotificationsTemplatingModule),// 通知模块 模板解析

    typeof(AbpSaasHttpApiModule),// Saas模块 控制器
    typeof(AbpSaasApplicationModule),// Saas模块 应用服务
    typeof(AbpSaasEntityFrameworkCoreModule),// Saas模块 实体框架
    typeof(AbpSaasDbCheckerModule),// Saas模块 数据库连接检查

    typeof(AbpSettingManagementHttpApiModule),// 设置管理模块 控制器
    typeof(AbpSettingManagementApplicationModule),// 设置管理模块 应用服务
    typeof(AbpSettingManagementEntityFrameworkCoreModule),// 设置管理模块 实体框架

    typeof(AbpTextTemplatingHttpApiModule),// 文本模板模块 控制器
    typeof(AbpTextTemplatingApplicationModule),// 文本模板模块 应用服务
    typeof(AbpTextTemplatingEntityFrameworkCoreModule),// 文本模板模块 实体框架

    typeof(RuiChenSingleHttpApiModule),
    typeof(RuiChenSingleApplicationModule),
    typeof(RuiChenSingleEntityFrameworkCoreModule),
    typeof(SingleMigrationEntityFrameworkCoreModule),

    typeof(AbpIP2RegionModule),
    typeof(AbpCAPEventBusModule),
    typeof(AbpAspNetCoreMvcWrapperModule),
    typeof(AbpAspNetCoreMvcIdempotentWrapperModule),
    typeof(AbpAspNetCoreHttpOverridesModule),
    typeof(AbpLocalizationCultureMapModule),
    typeof(AbpSerilogEnrichersApplicationModule),
    typeof(AbpSerilogEnrichersUniqueIdModule),


    typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule),
    typeof(AbpAspNetCoreMultiTenancyModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule),
    typeof(AbpAutofacModule)
)]
public partial class RuiChenSingleHttpApiHostModule : AbpModule
{

    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        var hostingEnvironment = context.Services.GetHostingEnvironment();

        PreConfigureFeature();
        PreConfigureIdentity();
        PreConfigureApp(configuration);
        PreConfigureCAP(configuration);
        PreConfigureAuthServer(configuration);
        PreConfigureCertificate(configuration, hostingEnvironment);
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var hostingEnvironment = context.Services.GetHostingEnvironment();
        var configuration = context.Services.GetConfiguration();

        ConfigureWrapper();
        ConfigureAuditing();
        ConfigureIdempotent();
        ConfigureLocalization();
        ConfigureExceptionHandling();
        ConfigureVirtualFileSystem();
        ConfigureUrls(configuration);
        ConfigureCaching(configuration);
        ConfigureAuditing(configuration);
        ConfigureIdentity(configuration);
        ConfigureDbContext(configuration);
        ConfigureAuthServer(configuration);
        ConfigureMultiTenancy(configuration);
        ConfigureJsonSerializer(configuration);
        ConfigureTextTemplating(configuration);
        ConfigureFeatureManagement(configuration);
        ConfigureSettingManagement(configuration);
        ConfigurePermissionManagement(configuration);
        ConfigureNotificationManagement(configuration);
        ConfigureCors(context.Services, configuration);
        ConfigureSwagger(context.Services, configuration);
        ConfigureDistributedLock(context.Services, configuration);
        ConfigureKestrelServer(configuration, hostingEnvironment);
        ConfigureOssManagement(context.Services, configuration);
        ConfigureSecurity(context.Services, configuration, hostingEnvironment.IsDevelopment());

        ConfigureSingleModule(context.Services, hostingEnvironment.IsDevelopment());
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var configuration = context.GetConfiguration();

        app.UseForwardedHeaders();

        app.UseAbpSecurityHeaders();

        app.UseCookiePolicy();

        app.UseMapRequestLocalization();

        app.UseCorrelationId();

        app.MapAbpStaticAssets();

        app.UseRouting();

        app.UseCors();

        app.UseAuthentication();

        app.UseAbpOpenIddictValidation();

        app.UseAbpSession();

        app.UseDynamicClaims();

        app.UseUnitOfWork();

        app.UseMultiTenancy();

        app.UseAuthorization();

        app.UseSwagger();

        app.UseAbpSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "RuiChenAdmin API");

            options.OAuthClientId(configuration["AuthServer:SwaggerClientId"]);
            options.OAuthScopes(configuration["AuthServer:Audience"]);
        });

        app.UseAuditing();

        app.UseAbpSerilogEnrichers();

        app.UseConfiguredEndpoints();

    }

}
