using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RuiChen.Abp.UI.Navigation;

public abstract class NavigationSeedContributor : INavigationSeedContributor, ITransientDependency
{
    public abstract Task SeedAsync(NavigationSeedContext context);
}
