﻿using Volo.Abp.DependencyInjection;

namespace RuiChen.Abp.UI.Navigation;

public abstract class NavigationDefinitionProvider : INavigationDefinitionProvider, ITransientDependency
{
    protected NavigationDefinitionProvider()
    {
    }
    public abstract void Define(INavigationDefinitionContext context);
}
