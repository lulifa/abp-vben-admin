using JetBrains.Annotations;
using System.Collections.Generic;

namespace RuiChen.Abp.IP.Location;
public class AbpIPLocationResolveOptions
{
    [NotNull]
    public List<IIPLocationResolveContributor> IPLocationResolvers { get; }

    public AbpIPLocationResolveOptions()
    {
        IPLocationResolvers = new List<IIPLocationResolveContributor>();
    }
}
