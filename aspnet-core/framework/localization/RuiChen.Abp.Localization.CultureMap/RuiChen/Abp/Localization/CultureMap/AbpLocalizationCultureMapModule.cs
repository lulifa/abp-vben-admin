﻿using Volo.Abp.AspNetCore;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Localization.CultureMap;

[DependsOn(typeof(AbpAspNetCoreModule))]
public class AbpLocalizationCultureMapModule : AbpModule
{
}
