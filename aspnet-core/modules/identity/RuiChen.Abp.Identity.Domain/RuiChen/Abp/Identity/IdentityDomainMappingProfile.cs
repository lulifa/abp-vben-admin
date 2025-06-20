using AutoMapper;
using Volo.Abp.Identity;

namespace RuiChen.Abp.Identity;

public class IdentityDomainMappingProfile : Profile
{
    public IdentityDomainMappingProfile()
    {
        CreateMap<IdentitySession, IdentitySessionEto>();
    }
}
