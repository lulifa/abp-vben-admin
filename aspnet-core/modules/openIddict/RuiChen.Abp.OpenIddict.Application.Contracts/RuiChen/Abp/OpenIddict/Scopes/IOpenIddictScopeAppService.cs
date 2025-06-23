using System;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.OpenIddict.Scopes;

public interface IOpenIddictScopeAppService :
    ICrudAppService<
        OpenIddictScopeDto,
        Guid,
        OpenIddictScopeGetListInput,
        OpenIddictScopeCreateDto,
        OpenIddictScopeUpdateDto>
{
}
