using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Saas.Editions;

public class EditionGetListInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
