using System.ComponentModel.DataAnnotations;
using Volo.Abp.Auditing;
using Volo.Abp.Content;

namespace RuiChen.Abp.Account;

public class ChangePictureInput
{
    [Required]
    [DisableAuditing]
    public IRemoteStreamContent File { get; set; }
}
