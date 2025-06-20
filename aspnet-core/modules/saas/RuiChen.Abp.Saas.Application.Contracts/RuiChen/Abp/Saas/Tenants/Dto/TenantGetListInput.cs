using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Saas.Tenants;

public class TenantGetListInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}