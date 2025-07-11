﻿using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Notifications;

public interface INotificationAppService
{
    Task<ListResultDto<NotificationProviderDto>> GetAssignableProvidersAsync();

    Task<ListResultDto<NotificationGroupDto>> GetAssignableNotifiersAsync();

    Task<ListResultDto<NotificationTemplateDto>> GetAssignableTemplatesAsync();

    Task SendAsync(NotificationSendDto input);

    Task SendTemplateAsync(NotificationTemplateSendDto input);
}
