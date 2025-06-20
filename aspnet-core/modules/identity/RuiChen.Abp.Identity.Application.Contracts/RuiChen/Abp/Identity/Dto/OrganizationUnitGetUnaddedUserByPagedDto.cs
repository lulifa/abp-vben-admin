using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Identity;

public class OrganizationUnitGetUnaddedUserByPagedDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
