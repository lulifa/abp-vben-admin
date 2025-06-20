using Volo.Abp.Domain.Entities;

namespace RuiChen.Platform.Portal;

public class EnterpriseUpdateDto : EnterpriseCreateOrUpdateDto, IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}
