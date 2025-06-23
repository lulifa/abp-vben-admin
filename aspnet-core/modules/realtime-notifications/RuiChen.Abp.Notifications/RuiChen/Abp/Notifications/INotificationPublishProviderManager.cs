using System.Collections.Generic;

namespace RuiChen.Abp.Notifications;

public interface INotificationPublishProviderManager
{
    List<INotificationPublishProvider> Providers { get; }
}
