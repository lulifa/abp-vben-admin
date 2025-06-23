using RuiChen.Abp.Notifications.Localization;
using Volo.Abp.Application.Services;

namespace RuiChen.Abp.Notifications;

public abstract class AbpNotificationsApplicationServiceBase : ApplicationService
{
    protected AbpNotificationsApplicationServiceBase()
    {
        LocalizationResource = typeof(NotificationsResource);
        ObjectMapperContext = typeof(AbpNotificationsApplicationModule);
    }
}
