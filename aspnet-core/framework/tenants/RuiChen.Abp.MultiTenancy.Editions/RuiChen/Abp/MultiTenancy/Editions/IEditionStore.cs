using System;
using System.Threading.Tasks;

namespace RuiChen.Abp.MultiTenancy.Editions;

public interface IEditionStore
{
    Task<EditionInfo> FindByTenantAsync(Guid tenantId);
}
