using System.Threading.Tasks;

namespace RuiChen.Abp.DataProtection;

public interface IDataAccessStrategyContributor
{
    string Name { get; }
    Task<DataAccessStrategyState> GetOrNullAsync(DataAccessStrategyContributorContext context);
}
