using System.Threading.Tasks;

namespace RuiChen.Abp.SettingManagement;

public interface ISettingAppService : IReadonlySettingAppService
{
    Task SetGlobalAsync(UpdateSettingsDto input);

    Task SetCurrentTenantAsync(UpdateSettingsDto input);
}
