using System.Threading.Tasks;

namespace RuiChen.Abp.EntityChange;

public interface IEntityRestoreAppService : IEntityChangeAppService
{
    Task RestoreEntityAsync(RestoreEntityInput input);

    Task RestoreEntitesAsync(RestoreEntitiesInput input);
}
