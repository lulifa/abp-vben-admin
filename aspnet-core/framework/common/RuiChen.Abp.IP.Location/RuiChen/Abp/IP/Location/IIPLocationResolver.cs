using JetBrains.Annotations;
using System.Threading.Tasks;

namespace RuiChen.Abp.IP.Location;
public interface IIPLocationResolver
{
    [NotNull]
    Task<IPLocationResolveResult> ResolveAsync(string ipAddress);
}
