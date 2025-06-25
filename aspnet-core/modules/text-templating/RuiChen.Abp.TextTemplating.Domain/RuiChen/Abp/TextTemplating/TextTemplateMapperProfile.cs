using AutoMapper;

namespace RuiChen.Abp.TextTemplating;
public class TextTemplateMapperProfile : Profile
{
    public TextTemplateMapperProfile()
    {
        CreateMap<TextTemplate, TextTemplateEto>();
        CreateMap<TextTemplateDefinition, TextTemplateDefinitionEto>();
    }
}
