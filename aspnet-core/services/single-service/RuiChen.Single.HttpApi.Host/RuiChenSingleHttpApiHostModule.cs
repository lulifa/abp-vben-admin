using RC.MicroService.Single.EntityFrameworkCore;
using RuiChen.Abp.Account;
using RuiChen.Abp.Account.Web.OpenIddict;
using RuiChen.Abp.AspNetCore.HttpOverrides;
using RuiChen.Abp.AspNetCore.Mvc.Wrapper;
using RuiChen.Abp.Auditing;
using RuiChen.Abp.AuditLogging.EntityFrameworkCore;
using RuiChen.Abp.Identity;
using RuiChen.Abp.Identity.EntityFrameworkCore;
using RuiChen.Abp.Localization.CultureMap;
using RuiChen.Abp.Saas;
using RuiChen.Abp.Saas.EntityFrameworkCore;
using RuiChen.Abp.SettingManagement;
using RuiChen.Platform;
using RuiChen.Platform.EntityFrameworkCore;
using RuiChen.Platform.HttpApi;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.VirtualFileExplorer.Web;

namespace RuiChen.Single.HttpApi.Host;

[DependsOn(
    typeof(AbpAccountHttpApiModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpAccountWebOpenIddictModule),

    typeof(AbpAuditingHttpApiModule),
    typeof(AbpAuditingApplicationModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),

    typeof(AbpIdentityHttpApiModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),


    typeof(AbpSaasHttpApiModule),
    typeof(AbpSaasApplicationModule),
    typeof(AbpSaasEntityFrameworkCoreModule),

    typeof(PlatformHttpApiModule),
    typeof(PlatformApplicationModule),
    typeof(PlatformEntityFrameworkCoreModule),

    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),

    typeof(SingleMigrationEntityFrameworkCoreModule),

    typeof(AbpAspNetCoreMvcWrapperModule),
    typeof(AbpAspNetCoreHttpOverridesModule),
    typeof(AbpLocalizationCultureMapModule),
    

    typeof(AbpVirtualFileExplorerWebModule),
    typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule),
    typeof(AbpAspNetCoreMultiTenancyModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpAutofacModule)
)]
public partial class RuiChenSingleHttpApiHostModule : AbpModule
{
}
