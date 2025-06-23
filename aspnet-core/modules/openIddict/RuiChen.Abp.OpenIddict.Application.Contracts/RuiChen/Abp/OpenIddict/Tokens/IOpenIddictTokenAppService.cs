using System;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.OpenIddict.Tokens;

public interface IOpenIddictTokenAppService :
    IReadOnlyAppService<
        OpenIddictTokenDto,
        Guid,
        OpenIddictTokenGetListInput>,
    IDeleteAppService<Guid>
{
}
