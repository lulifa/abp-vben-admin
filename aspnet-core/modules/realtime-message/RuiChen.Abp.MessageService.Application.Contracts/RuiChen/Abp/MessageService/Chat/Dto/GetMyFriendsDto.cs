using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.MessageService.Chat;

public class GetMyFriendsDto : ISortedResultRequest
{
    public string Sorting { get; set; }
}
