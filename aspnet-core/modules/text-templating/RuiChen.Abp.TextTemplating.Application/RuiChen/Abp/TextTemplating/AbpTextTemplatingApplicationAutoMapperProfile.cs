using AutoMapper;

namespace RuiChen.Abp.TextTemplating;

public class AbpTextTemplatingApplicationAutoMapperProfile : Profile
{
    public AbpTextTemplatingApplicationAutoMapperProfile()
    {
        CreateMap<TextTemplateDefinition, TextTemplateDefinitionDto>();
    }
}
