using Microsoft.EntityFrameworkCore;
using RuiChen.Abp.DataProtectionManagement.EntityFrameworkCore;
using RuiChen.Abp.LocalizationManagement.EntityFrameworkCore;
using RuiChen.Abp.MessageService.EntityFrameworkCore;
using RuiChen.Abp.Notifications.EntityFrameworkCore;
using RuiChen.Abp.Saas.EntityFrameworkCore;
using RuiChen.Abp.TextTemplating.EntityFrameworkCore;
using RuiChen.Platform.EntityFrameworkCore;
using RuiChen.Single.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace RC.MicroService.Single.EntityFrameworkCore;

public class SingleMigrationDbContext : AbpDbContext<SingleMigrationDbContext>
{
    public SingleMigrationDbContext(DbContextOptions<SingleMigrationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAuditLogging();
        modelBuilder.ConfigureIdentity();
        modelBuilder.ConfigureOpenIddict();
        modelBuilder.ConfigureSaas();
        modelBuilder.ConfigureFeatureManagement();
        modelBuilder.ConfigureSettingManagement();
        modelBuilder.ConfigurePermissionManagement();
        modelBuilder.ConfigureTextTemplating();
        modelBuilder.ConfigurePlatform();
        modelBuilder.ConfigureLocalization();
        modelBuilder.ConfigureNotifications();
        modelBuilder.ConfigureNotificationsDefinition();
        modelBuilder.ConfigureMessageService();
        modelBuilder.ConfigureDataProtectionManagement();
        modelBuilder.ConfigureSingle();

    }
}
