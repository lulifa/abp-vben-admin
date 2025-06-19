using System.Threading.Tasks;

namespace RuiChen.Abp.IP.Location;
public interface IIPLocationResolveContributor
{
    string Name { get; }

    Task ResolveAsync(IIPLocationResolveContext context);
}
