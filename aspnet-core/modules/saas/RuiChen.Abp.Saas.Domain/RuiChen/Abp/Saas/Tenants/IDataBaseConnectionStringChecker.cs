using System.Threading.Tasks;

namespace RuiChen.Abp.Saas.Tenants;

public interface IDataBaseConnectionStringChecker
{
    Task<DataBaseConnectionStringCheckResult> CheckAsync(string connectionString);
}
