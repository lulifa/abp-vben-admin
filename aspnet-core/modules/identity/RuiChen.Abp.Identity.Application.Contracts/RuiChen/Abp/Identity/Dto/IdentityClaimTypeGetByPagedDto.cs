using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Identity;

public class IdentityClaimTypeGetByPagedDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
