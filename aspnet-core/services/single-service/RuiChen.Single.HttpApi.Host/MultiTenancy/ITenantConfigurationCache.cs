using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.MultiTenancy;

namespace RuiChen.Single.HttpApi.Host.MultiTenancy;

public interface ITenantConfigurationCache
{
    Task RefreshAsync();

    Task<List<TenantConfiguration>> GetTenantsAsync();
}
