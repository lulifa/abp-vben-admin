using System.Threading.Tasks;

namespace RuiChen.Abp.LocalizationManagement;

public interface IStaticLocalizationSaver
{
    Task SaveAsync();
}
