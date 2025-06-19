using AutoMapper;
using RuiChen.Abp.AuditLogging;

namespace RuiChen.Abp.EntityChange;
public class AbpEntityChangeMapperProfile : Profile
{
    public AbpEntityChangeMapperProfile()
    {
        CreateMap<EntityPropertyChange, EntityPropertyChangeDto>();
        CreateMap<AuditLogging.EntityChange, EntityChangeDto>()
            .MapExtraProperties();
    }
}
