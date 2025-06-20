using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace RuiChen.Platform.Theme.VueVbenAdmin;

public interface IThemeSettingAppService : IApplicationService
{
    Task<ThemeSettingDto> GetAsync();

    Task ChangeAsync(ThemeSettingDto input);
}
