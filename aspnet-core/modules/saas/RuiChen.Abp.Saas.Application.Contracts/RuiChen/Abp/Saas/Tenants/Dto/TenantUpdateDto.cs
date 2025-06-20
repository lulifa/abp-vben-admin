using Volo.Abp.Domain.Entities;

namespace RuiChen.Abp.Saas.Tenants;
public class TenantUpdateDto : TenantCreateOrUpdateBase, IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}