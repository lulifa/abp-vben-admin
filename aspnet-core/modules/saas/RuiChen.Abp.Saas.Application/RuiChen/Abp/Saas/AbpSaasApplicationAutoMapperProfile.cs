using AutoMapper;
using RuiChen.Abp.Saas.Editions;
using RuiChen.Abp.Saas.Tenants;

namespace RuiChen.Abp.Saas;

public class AbpSaasApplicationAutoMapperProfile : Profile
{
    public AbpSaasApplicationAutoMapperProfile()
    {
        CreateMap<TenantConnectionString, TenantConnectionStringDto>();

        CreateMap<Tenant, TenantDto>()
            .ForMember(dto => dto.EditionId, map =>
            {
                map.MapFrom((tenant, dto) =>
                {
                    return tenant.Edition?.Id;
                });
            })
            .ForMember(dto => dto.EditionName, map =>
            {
                map.MapFrom((tenant, dto) =>
                {
                    return tenant.Edition?.DisplayName;
                });
            })
            .MapExtraProperties();

        CreateMap<Edition, EditionDto>()
            .MapExtraProperties();
    }
}
