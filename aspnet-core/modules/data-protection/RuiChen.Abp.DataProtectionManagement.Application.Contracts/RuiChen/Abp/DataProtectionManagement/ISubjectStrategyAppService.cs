using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.DataProtectionManagement;

public interface ISubjectStrategyAppService : IApplicationService
{
    Task<SubjectStrategyDto> GetAsync(SubjectStrategyGetInput input);

    Task<SubjectStrategyDto> SetAsync(SubjectStrategySetInput input);
}
