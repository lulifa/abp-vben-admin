using AutoMapper;
using RuiChen.Abp.AuditLogging;

namespace RuiChen.Abp.Account;

public class AbpAccountMapperProfile : Profile
{
    public AbpAccountMapperProfile()
    {
        CreateMap<SecurityLog, SecurityLogDto>(MemberList.Destination);
    }
}
