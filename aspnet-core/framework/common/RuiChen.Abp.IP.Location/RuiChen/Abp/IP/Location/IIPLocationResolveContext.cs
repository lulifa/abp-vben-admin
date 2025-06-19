using Volo.Abp.DependencyInjection;

namespace RuiChen.Abp.IP.Location;
public interface IIPLocationResolveContext : IServiceProviderAccessor
{
    string IpAddress { get; }

    IPLocation? Location { get; set; }

    bool Handled { get; set; }
}
