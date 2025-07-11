﻿using RuiChen.Abp.Features.LimitValidation;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace RuiChen.Abp.OssManagement;

[DependsOn(
    typeof(AbpOssManagementDomainSharedModule),
    typeof(AbpDddDomainModule),
    typeof(AbpMultiTenancyModule),
    typeof(AbpFeaturesLimitValidationModule)
    )]
public class AbpOssManagementDomainModule : AbpModule
{
}
