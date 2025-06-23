﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace RuiChen.Abp.Notifications;

public interface IDynamicNotificationDefinitionStore
{
    Task<NotificationDefinition> GetOrNullAsync(string name);

    Task<IReadOnlyList<NotificationDefinition>> GetNotificationsAsync();

    Task<NotificationGroupDefinition> GetGroupOrNullAsync(string name);

    Task<IReadOnlyList<NotificationGroupDefinition>> GetGroupsAsync();
}
