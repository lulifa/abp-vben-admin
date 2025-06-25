using Volo.Abp.Validation;

namespace RuiChen.Abp.TextTemplating;

public class TextTemplateRestoreInput
{
    [DynamicStringLength(typeof(TextTemplateConsts), nameof(TextTemplateConsts.MaxCultureLength))]
    public string Culture { get; set; }
}
