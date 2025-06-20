using RuiChen.Platform.Routes;
using Volo.Abp.Validation;

namespace RuiChen.Platform.Menus;

public class GetMenuInput
{
    [DynamicStringLength(typeof(LayoutConsts), nameof(LayoutConsts.MaxFrameworkLength))]
    public string Framework { get; set; }
}
