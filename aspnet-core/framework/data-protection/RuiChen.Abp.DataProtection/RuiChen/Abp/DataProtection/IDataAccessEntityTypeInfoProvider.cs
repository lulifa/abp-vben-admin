using RuiChen.Abp.DataProtection.Models;
using System.Threading.Tasks;

namespace RuiChen.Abp.DataProtection;

public interface IDataAccessEntityTypeInfoProvider
{
    Task<EntityTypeInfoModel> GetEntitTypeInfoAsync(DataAccessEntitTypeInfoContext context);
}
