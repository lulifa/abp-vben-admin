using System.Threading.Tasks;

namespace RuiChen.Abp.DataProtection;

public interface IDataAccessStrategyStateProvider
{
    Task<DataAccessStrategyState> GetOrNullAsync();
}
