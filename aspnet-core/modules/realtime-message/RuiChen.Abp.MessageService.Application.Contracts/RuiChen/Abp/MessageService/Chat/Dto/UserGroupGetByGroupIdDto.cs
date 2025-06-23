using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.MessageService.Chat;

public class UserGroupGetByGroupIdDto
{
    [Required]
    public long GroupId { get; set; }
}
