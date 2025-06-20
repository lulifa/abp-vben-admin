using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace RuiChen.Abp.Saas.ObjectExtending;

public static class SaasModuleExtensionConfigurationDictionaryExtensions
{
    public static ModuleExtensionConfigurationDictionary ConfigureTenantManagement(
        this ModuleExtensionConfigurationDictionary modules,
        Action<SaasModuleExtensionConfiguration> configureAction)
    {
        return modules.ConfigureModule(
            SaasModuleExtensionConsts.ModuleName,
            configureAction
        );
    }
}
