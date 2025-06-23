using System.Threading;
using System.Threading.Tasks;

namespace RuiChen.Abp.DataProtectionManagement;
public interface IProtectedEntitiesSaver
{
    Task SaveAsync(CancellationToken cancellationToken = default);
}
