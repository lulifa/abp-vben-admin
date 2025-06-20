using RuiChen.Platform.Datas;
using RuiChen.Platform.Feedbacks;
using RuiChen.Platform.Layouts;
using RuiChen.Platform.Menus;
using RuiChen.Platform.Messages;
using RuiChen.Platform.Packages;
using RuiChen.Platform.Portal;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RuiChen.Platform.EntityFrameworkCore;

[DependsOn(
    typeof(PlatformDomainModule),
    typeof(AbpEntityFrameworkCoreModule))]
public class PlatformEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<PlatformDbContext>(options =>
        {
            options.AddRepository<Data, EfCoreDataRepository>();
            options.AddRepository<Menu, EfCoreMenuRepository>();
            options.AddRepository<UserMenu, EfCoreUserMenuRepository>();
            options.AddRepository<RoleMenu, EfCoreRoleMenuRepository>();
            options.AddRepository<UserFavoriteMenu, EfCoreUserFavoriteMenuRepository>();
            options.AddRepository<Layout, EfCoreLayoutRepository>();
            options.AddRepository<Package, EfCorePackageRepository>();
            options.AddRepository<Enterprise, EfCoreEnterpriseRepository>();

            options.AddRepository<Feedback, EfCoreFeedbackRepository>();

            options.AddRepository<SmsMessage, EfCoreSmsMessageRepository>();
            options.AddRepository<EmailMessage, EfCoreEmailMessageRepository>();

            options.AddDefaultRepositories(includeAllEntities: true);
        });
    }
}
