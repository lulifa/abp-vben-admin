﻿using RuiChen.Abp.Identity;
using Volo.Abp.Emailing;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Notifications.Emailing;

[DependsOn(
    typeof(AbpNotificationsModule),
    typeof(AbpEmailingModule),
    typeof(AbpIdentityDomainModule))]
public class AbpNotificationsEmailingModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNotificationsPublishOptions>(options =>
        {
            options.PublishProviders.Add<EmailingNotificationPublishProvider>();
        });
    }
}
