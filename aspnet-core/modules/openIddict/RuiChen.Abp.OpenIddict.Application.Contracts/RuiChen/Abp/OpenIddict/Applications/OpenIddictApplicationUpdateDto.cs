using System;
using Volo.Abp.Domain.Entities;

namespace RuiChen.Abp.OpenIddict.Applications;

[Serializable]
public class OpenIddictApplicationUpdateDto : OpenIddictApplicationCreateOrUpdateDto, IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}
