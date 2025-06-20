using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace RuiChen.Platform.Messages.Integration;

[IntegrationService]
public interface IEmailMessageIntegrationService : IApplicationService
{
    /// <summary>
    /// 创建邮件消息
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EmailMessageDto> CreateAsync(EmailMessageCreateDto input);
}
