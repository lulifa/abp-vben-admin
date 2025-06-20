using AutoMapper;
using Volo.Abp.ObjectExtending;

namespace RuiChen.Abp.AuditLogging.EntityFrameworkCore;

public class AbpAuditingMapperProfile : Profile
{
    public AbpAuditingMapperProfile()
    {
        CreateMap<Volo.Abp.AuditLogging.AuditLogAction, RuiChen.Abp.AuditLogging.AuditLogAction>()
            .MapExtraProperties(MappingPropertyDefinitionChecks.None);
        CreateMap<Volo.Abp.AuditLogging.EntityPropertyChange, RuiChen.Abp.AuditLogging.EntityPropertyChange>();
        CreateMap<Volo.Abp.AuditLogging.EntityChange, RuiChen.Abp.AuditLogging.EntityChange>()
            .MapExtraProperties(MappingPropertyDefinitionChecks.None);
        CreateMap<Volo.Abp.AuditLogging.AuditLog, RuiChen.Abp.AuditLogging.AuditLog>()
            .MapExtraProperties(MappingPropertyDefinitionChecks.None);

        CreateMap<Volo.Abp.AuditLogging.EntityChangeWithUsername, RuiChen.Abp.AuditLogging.EntityChangeWithUsername>();

        CreateMap<Volo.Abp.Identity.IdentitySecurityLog, RuiChen.Abp.AuditLogging.SecurityLog>(MemberList.Destination)
            .MapExtraProperties(MappingPropertyDefinitionChecks.None);
    }
}
