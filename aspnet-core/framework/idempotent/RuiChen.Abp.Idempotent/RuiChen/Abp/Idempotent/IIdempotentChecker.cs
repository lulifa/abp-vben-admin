using System.Threading.Tasks;

namespace RuiChen.Abp.Idempotent;

public interface IIdempotentChecker
{
    Task<IdempotentGrantResult> IsGrantAsync(IdempotentCheckContext context);
}
