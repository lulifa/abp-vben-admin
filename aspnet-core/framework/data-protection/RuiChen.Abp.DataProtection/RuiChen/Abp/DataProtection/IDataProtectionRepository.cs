using System.Linq;
using System.Threading.Tasks;

namespace RuiChen.Abp.DataProtection;
public interface IDataProtectionRepository<TEntity> : IDataProtectedEnabled
{
    Task<IQueryable<TEntity>> GetQueryableAsync();
}
