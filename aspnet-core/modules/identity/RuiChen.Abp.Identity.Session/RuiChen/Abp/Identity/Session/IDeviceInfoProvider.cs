using System.Threading.Tasks;

namespace RuiChen.Abp.Identity.Session;
public interface IDeviceInfoProvider
{
    Task<DeviceInfo> GetDeviceInfoAsync();

    string ClientIpAddress { get; }
}
