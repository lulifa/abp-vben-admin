﻿using Microsoft.Extensions.Options;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace RuiChen.Single.HttpApi.Host;

public class NotificationPublishJob : AsyncBackgroundJob<NotificationPublishJobArgs>, ITransientDependency
{
    protected AbpNotificationsPublishOptions Options { get; }
    protected IServiceScopeFactory ServiceScopeFactory { get; }
    protected INotificationDataSerializer NotificationDataSerializer { get; }
    public NotificationPublishJob(
        IOptions<AbpNotificationsPublishOptions> options,
        IServiceScopeFactory serviceScopeFactory,
        INotificationDataSerializer notificationDataSerializer)
    {
        Options = options.Value;
        ServiceScopeFactory = serviceScopeFactory;
        NotificationDataSerializer = notificationDataSerializer;
    }

    public override async Task ExecuteAsync(NotificationPublishJobArgs args)
    {
        var providerType = Type.GetType(args.ProviderType);
        using (var scope = ServiceScopeFactory.CreateScope())
        {
            if (scope.ServiceProvider.GetRequiredService(providerType) is INotificationPublishProvider publishProvider)
            {
                var store = scope.ServiceProvider.GetRequiredService<INotificationStore>();
                var notification = await store.GetNotificationOrNullAsync(args.TenantId, args.NotificationId);
                notification.Data = NotificationDataSerializer.Serialize(notification.Data);

                await publishProvider.PublishAsync(notification, args.UserIdentifiers);
            }
        }
    }
}
