﻿using System;
using Volo.Abp.EventBus;

namespace RuiChen.Abp.DataProtection;

[Serializable]
[EventName("abp.data_protection.resource_changed")]
public class DataAccessResourceChangeEvent
{
    public bool IsEnabled { get; set; }
    public DataAccessResource Resource { get; set; }
    public DataAccessResourceChangeEvent()
    {

    }

    public DataAccessResourceChangeEvent(bool isEnabled, DataAccessResource resource)
    {
        IsEnabled = isEnabled;
        Resource = resource;
    }
}
