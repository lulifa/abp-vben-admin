using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Localization;

namespace RuiChen.Abp.LocalizationManagement;

public interface ILocalizationLanguageStoreCache
{
    Task<IReadOnlyList<LanguageInfo>> GetLanguagesAsync();
}
