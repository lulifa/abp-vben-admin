﻿using AutoMapper;

namespace RuiChen.Abp.DataProtectionManagement;
public class DataProtectionManagementDomainMappingProfile : Profile
{
    public DataProtectionManagementDomainMappingProfile()
    {
        CreateMap<EntityTypeInfo, EntityTypeInfoEto>();
        CreateMap<RoleEntityRule, RoleEntityRuleEto>();
        CreateMap<OrganizationUnitEntityRule, OrganizationUnitEntityRuleEto>();
    }
}
