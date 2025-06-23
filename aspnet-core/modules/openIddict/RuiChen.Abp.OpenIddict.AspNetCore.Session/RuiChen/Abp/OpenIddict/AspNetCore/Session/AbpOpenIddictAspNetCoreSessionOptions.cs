using System.Collections.Generic;

namespace RuiChen.Abp.OpenIddict.AspNetCore.Session;
public class AbpOpenIddictAspNetCoreSessionOptions
{
    public List<string> PersistentSessionGrantTypes { get; set; }
    public AbpOpenIddictAspNetCoreSessionOptions()
    {
        PersistentSessionGrantTypes = new List<string>();
    }
}
