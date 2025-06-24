using System.Threading.Tasks;

namespace RuiChen.Abp.Notifications.Templating;
public interface INotificationTemplateResolveContributor
{
    string Name { get; }

    Task ResolveAsync(INotificationTemplateResolveContext context);
}
