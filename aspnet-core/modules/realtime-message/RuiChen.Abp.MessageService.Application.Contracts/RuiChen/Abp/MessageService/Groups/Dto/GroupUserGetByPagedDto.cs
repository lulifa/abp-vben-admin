using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.MessageService.Groups;

public class GroupUserGetByPagedDto : PagedAndSortedResultRequestDto
{
    [Required]
    public long GroupId { get; set; }

    public string Filter { get; set; }
}
