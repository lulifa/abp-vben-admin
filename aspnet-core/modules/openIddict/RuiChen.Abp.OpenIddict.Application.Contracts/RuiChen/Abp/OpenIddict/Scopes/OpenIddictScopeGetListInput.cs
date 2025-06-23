using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.OpenIddict.Scopes;

[Serializable]
public class OpenIddictScopeGetListInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
