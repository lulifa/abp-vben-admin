using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.LocalizationManagement;

public interface ITextAppService : IApplicationService
{
    Task SetTextAsync(SetTextInput input);

    Task RestoreToDefaultAsync(RestoreDefaultTextInput input);
}
