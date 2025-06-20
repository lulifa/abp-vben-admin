﻿using System;
using Volo.Abp.EventBus;

namespace RuiChen.Abp.Saas.Tenants;

[Serializable]
[EventName("abp.saas.tenant.deleted")]
public class TenantDeletedEto : TenantEto
{
    public RecycleStrategy Strategy { get; set; }
    public string DefaultConnectionString { get; set; }
}
