using RC.MicroService.Single.EntityFrameworkCore;
using RuiChen.Abp.Account;
using RuiChen.Abp.Account.Web.OAuth;
using RuiChen.Abp.Account.Web.OpenIddict;
using RuiChen.Abp.AspNetCore.HttpOverrides;
using RuiChen.Abp.AspNetCore.Mvc.Idempotent.Wrapper;
using RuiChen.Abp.AspNetCore.Mvc.Wrapper;
using RuiChen.Abp.Auditing;
using RuiChen.Abp.AuditLogging.EntityFrameworkCore;
using RuiChen.Abp.AuditLogging.IP.Location;
using RuiChen.Abp.CachingManagement;
using RuiChen.Abp.CachingManagement.StackExchangeRedis;
using RuiChen.Abp.DataProtectionManagement;
using RuiChen.Abp.DataProtectionManagement.EntityFrameworkCore;
using RuiChen.Abp.EventBus.CAP;
using RuiChen.Abp.FeatureManagement;
using RuiChen.Abp.FeatureManagement.HttpApi;
using RuiChen.Abp.Identity;
using RuiChen.Abp.Identity.AspNetCore.Session;
using RuiChen.Abp.Identity.EntityFrameworkCore;
using RuiChen.Abp.Identity.Notifications;
using RuiChen.Abp.Identity.OrganizaztionUnits;
using RuiChen.Abp.Identity.Session.AspNetCore;
using RuiChen.Abp.IM;
using RuiChen.Abp.IM.SignalR;
using RuiChen.Abp.Localization.CultureMap;
using RuiChen.Abp.LocalizationManagement;
using RuiChen.Abp.LocalizationManagement.EntityFrameworkCore;
using RuiChen.Abp.MessageService;
using RuiChen.Abp.MessageService.EntityFrameworkCore;
using RuiChen.Abp.Notifications;
using RuiChen.Abp.Notifications.Common;
using RuiChen.Abp.Notifications.Emailing;
using RuiChen.Abp.Notifications.EntityFrameworkCore;
using RuiChen.Abp.Notifications.SignalR;
using RuiChen.Abp.OpenIddict;
using RuiChen.Abp.OpenIddict.AspNetCore.Session;
using RuiChen.Abp.OpenIddict.LinkUser;
using RuiChen.Abp.OpenIddict.Portal;
using RuiChen.Abp.OpenIddict.QrCode;
using RuiChen.Abp.OpenIddict.Sms;
using RuiChen.Abp.PermissionManagement;
using RuiChen.Abp.PermissionManagement.HttpApi;
using RuiChen.Abp.PermissionManagement.OrganizationUnits;
using RuiChen.Abp.Saas;
using RuiChen.Abp.Saas.EntityFrameworkCore;
using RuiChen.Abp.Serilog.Enrichers.Application;
using RuiChen.Abp.Serilog.Enrichers.UniqueId;
using RuiChen.Abp.SettingManagement;
using RuiChen.Abp.UI.Navigation.VueVbenAdmin5;
using RuiChen.Platform;
using RuiChen.Platform.EntityFrameworkCore;
using RuiChen.Platform.HttpApi;
using RuiChen.Platform.Settings.VueVbenAdmin;
using RuiChen.Platform.Theme.VueVbenAdmin;
using RuiChen.Single.EntityFrameworkCore;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.OpenIddict;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.VirtualFileExplorer.Web;

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

    typeof(AbpFeatureManagementHttpApiModule),// 功能管理模块 控制器
    typeof(AbpFeatureManagementApplicationModule),// 功能管理模块 应用服务
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

    typeof(AbpSaasHttpApiModule),// Saas模块 控制器
    typeof(AbpSaasApplicationModule),// Saas模块 应用服务
    typeof(AbpSaasEntityFrameworkCoreModule),// Saas模块 实体框架
    typeof(AbpSaasDbCheckerModule),// Saas模块 数据库连接检查

    typeof(AbpSettingManagementHttpApiModule),// 设置管理模块 控制器
    typeof(AbpSettingManagementApplicationModule),// 设置管理模块 应用服务
    typeof(AbpSettingManagementEntityFrameworkCoreModule),// 设置管理模块 实体框架

    typeof(RuiChenSingleHttpApiModule),
    typeof(RuiChenSingleApplicationModule),
    typeof(RuiChenSingleEntityFrameworkCoreModule),
    typeof(SingleMigrationEntityFrameworkCoreModule),

    typeof(AbpCAPEventBusModule),
    typeof(AbpAspNetCoreMvcWrapperModule),
    typeof(AbpAspNetCoreMvcIdempotentWrapperModule),
    typeof(AbpAspNetCoreHttpOverridesModule),
    typeof(AbpLocalizationCultureMapModule),
    typeof(AbpSerilogEnrichersApplicationModule),
    typeof(AbpSerilogEnrichersUniqueIdModule),


    typeof(AbpVirtualFileExplorerWebModule),
    typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule),
    typeof(AbpAspNetCoreMultiTenancyModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpAutofacModule)
)]
public partial class RuiChenSingleHttpApiHostModule : AbpModule
{

    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        base.PreConfigureServices(context);
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
    }

}
