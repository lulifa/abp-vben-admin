using System;
using Volo.Abp.Data;

namespace RuiChen.Abp.Saas.Tenants;

public class DataBaseConnectionStringCheckResult : AbpConnectionStringCheckResult
{
    public Exception Error { get; set; }
}
