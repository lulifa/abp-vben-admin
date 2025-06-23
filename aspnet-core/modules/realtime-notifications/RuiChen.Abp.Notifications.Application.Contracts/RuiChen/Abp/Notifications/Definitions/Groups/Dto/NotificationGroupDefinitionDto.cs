﻿using Volo.Abp.ObjectExtending;

namespace RuiChen.Abp.Notifications.Definitions.Groups;

public class NotificationGroupDefinitionDto : ExtensibleObject
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public bool IsStatic { get; set; }
    public bool AllowSubscriptionToClients { get; set; }
}
