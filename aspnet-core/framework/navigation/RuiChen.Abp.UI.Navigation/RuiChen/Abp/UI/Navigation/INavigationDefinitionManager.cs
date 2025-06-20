using System.Collections.Generic;

namespace RuiChen.Abp.UI.Navigation;

public interface INavigationDefinitionManager
{
    IReadOnlyList<NavigationDefinition> GetAll();
}
