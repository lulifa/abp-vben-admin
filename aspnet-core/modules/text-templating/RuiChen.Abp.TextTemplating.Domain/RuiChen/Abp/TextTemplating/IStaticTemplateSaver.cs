using System.Threading.Tasks;

namespace RuiChen.Abp.TextTemplating;
public interface IStaticTemplateSaver
{
    Task SaveDefinitionTemplateAsync();

    Task SaveTemplateContentAsync();
}
