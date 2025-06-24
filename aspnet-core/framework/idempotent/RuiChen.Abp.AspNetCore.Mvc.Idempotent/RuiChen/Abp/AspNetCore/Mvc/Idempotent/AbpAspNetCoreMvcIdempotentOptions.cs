using System.Collections.Generic;

namespace RuiChen.Abp.AspNetCore.Mvc.Idempotent;
public class AbpAspNetCoreMvcIdempotentOptions
{
    public List<string> SupportedMethods { get; }
    public AbpAspNetCoreMvcIdempotentOptions()
    {
        SupportedMethods = new List<string>
        {
            "POST",
            "PUT",
            "PATCH",
            // "DELETE"
        };
    }
}
