using Volo.Abp.Application.Dtos;

namespace RuiChen.Single.Books;

public class BookGetListInput : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
