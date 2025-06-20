using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Identity;

public class OrganizationUnitGetUnaddedRoleByPagedDto : PagedAndSortedResultRequestDto
{

    public string Filter { get; set; }
}
