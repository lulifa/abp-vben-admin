﻿using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict;

namespace RuiChen.Abp.OpenIddict;

[DependsOn(
    typeof(AbpOpenIddictApplicationContractsModule),
    typeof(AbpOpenIddictDomainModule),
    typeof(AbpDddApplicationModule))]
public class AbpOpenIddictApplicationModule : AbpModule
{
}
