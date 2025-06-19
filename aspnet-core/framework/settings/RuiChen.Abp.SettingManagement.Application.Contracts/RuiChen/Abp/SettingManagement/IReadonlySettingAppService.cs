using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.SettingManagement;

public interface IReadonlySettingAppService : IApplicationService
{
    Task<SettingGroupResult> GetAllForGlobalAsync();

    Task<SettingGroupResult> GetAllForCurrentTenantAsync();
}
