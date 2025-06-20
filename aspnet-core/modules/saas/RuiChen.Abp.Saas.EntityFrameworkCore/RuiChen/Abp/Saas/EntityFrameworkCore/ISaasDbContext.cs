using RuiChen.Abp.Saas.Editions;
using RuiChen.Abp.Saas.Tenants;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.MultiTenancy;

namespace RuiChen.Abp.Saas.EntityFrameworkCore;

[IgnoreMultiTenancy]
[ConnectionStringName(AbpSaasDbProperties.ConnectionStringName)]
public interface ISaasDbContext : IEfCoreDbContext
{
    DbSet<Edition> Editions { get; }
    DbSet<Tenant> Tenants { get; }
    DbSet<TenantConnectionString> TenantConnectionStrings { get; }
}
