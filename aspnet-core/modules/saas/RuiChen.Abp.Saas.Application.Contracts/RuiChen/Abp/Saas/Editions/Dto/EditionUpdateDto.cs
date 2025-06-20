using Volo.Abp.Domain.Entities;

namespace RuiChen.Abp.Saas.Editions;

public class EditionUpdateDto : EditionCreateOrUpdateBase, IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}
