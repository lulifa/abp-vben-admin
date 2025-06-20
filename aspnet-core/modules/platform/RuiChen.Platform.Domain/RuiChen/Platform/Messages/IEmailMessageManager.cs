using System.Threading.Tasks;

namespace RuiChen.Platform.Messages;
public interface IEmailMessageManager
{
    Task<EmailMessage> SendAsync(EmailMessage message);
}
