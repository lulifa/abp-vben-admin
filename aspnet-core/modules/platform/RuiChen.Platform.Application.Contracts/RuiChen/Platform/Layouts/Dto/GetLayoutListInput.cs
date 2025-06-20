using RuiChen.Platform.Routes;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;

namespace RuiChen.Platform.Layouts;

public class GetLayoutListInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }

    [DynamicStringLength(typeof(LayoutConsts), nameof(LayoutConsts.MaxFrameworkLength))]
    public string Framework { get; set; }
}
