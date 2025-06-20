using System.Collections.Generic;
using System.Threading.Tasks;

namespace RuiChen.Abp.UI.Navigation;

public interface INavigationProvider
{
    Task<IReadOnlyCollection<ApplicationMenu>> GetAllAsync();
}
