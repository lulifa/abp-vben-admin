﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Sms;

namespace RuiChen.Abp.Notifications.Sms;

[DependsOn(
    typeof(AbpNotificationsModule),
    typeof(AbpSmsModule))]
public class AbpNotificationsSmsModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var preSmsActions = context.Services.GetPreConfigureActions<AbpNotificationsSmsOptions>();
        Configure<AbpNotificationsSmsOptions>(options =>
        {
            preSmsActions.Configure(options);
        });

        Configure<AbpNotificationsPublishOptions>(options =>
        {
            options.PublishProviders.Add<SmsNotificationPublishProvider>();
        });
    }
}
