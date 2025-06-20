using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Identity;

public class OrganizationUnitGetByPagedDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
