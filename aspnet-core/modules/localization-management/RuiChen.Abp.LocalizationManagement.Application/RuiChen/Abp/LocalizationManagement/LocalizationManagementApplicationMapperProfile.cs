using AutoMapper;

namespace RuiChen.Abp.LocalizationManagement;

public class LocalizationManagementApplicationMapperProfile : Profile
{
    public LocalizationManagementApplicationMapperProfile()
    {
        CreateMap<Language, LanguageDto>();
        CreateMap<Resource, ResourceDto>();
    }
}
