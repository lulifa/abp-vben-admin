using Volo.Abp.Domain.Entities;

namespace RuiChen.Abp.TextTemplating;
public class TextTemplateDefinitionUpdateDto : TextTemplateDefinitionCreateOrUpdateDto, IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}
