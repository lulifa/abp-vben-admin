using Volo.Abp.Application.Dtos;

namespace RuiChen.Platform.Datas;

public class GetDataListInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
