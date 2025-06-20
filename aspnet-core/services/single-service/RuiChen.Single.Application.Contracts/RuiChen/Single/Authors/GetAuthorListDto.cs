using Volo.Abp.Application.Dtos;

namespace RuiChen.Single.Authors;
public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}