using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.MessageService.Groups;

public class GroupSearchInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
