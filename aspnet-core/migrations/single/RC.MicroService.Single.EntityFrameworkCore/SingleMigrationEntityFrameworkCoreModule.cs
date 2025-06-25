using Microsoft.Extensions.DependencyInjection;
using RC.MicroService.Single.EntityFrameworkCore.DataSeeder;
using RuiChen.Abp.AuditLogging.EntityFrameworkCore;
using RuiChen.Abp.Data.DbMigrator;
using RuiChen.Abp.Identity.EntityFrameworkCore;
using RuiChen.Abp.LocalizationManagement.EntityFrameworkCore;
using RuiChen.Abp.MessageService.EntityFrameworkCore;
using RuiChen.Abp.Notifications.EntityFrameworkCore;
using RuiChen.Abp.Saas.EntityFrameworkCore;
using RuiChen.Abp.TextTemplating.EntityFrameworkCore;
using RuiChen.Platform.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace RC.MicroService.Single.EntityFrameworkCore;

[DependsOn(
    typeof(AbpSaasEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule),
    typeof(AbpNotificationsEntityFrameworkCoreModule),
    typeof(AbpMessageServiceEntityFrameworkCoreModule),
    typeof(PlatformEntityFrameworkCoreModule),
    typeof(AbpLocalizationManagementEntityFrameworkCoreModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpOpenIddictEntityFrameworkCoreModule),
    typeof(AbpTextTemplatingEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreMySQLModule),
    typeof(AbpDataDbMigratorModule)
    )]
public class SingleMigrationEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<SingleMigrationDbContext>();
        context.Services.AddHostedService<SingleDataSeederWorker>();

        Configure<AbpDbContextOptions>(options =>
        {
            options.UseMySQL(
                mysql =>
                {
                    // see: https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/1960
                    mysql.TranslateParameterizedCollectionsToConstants();
                });
        });
    }

}
