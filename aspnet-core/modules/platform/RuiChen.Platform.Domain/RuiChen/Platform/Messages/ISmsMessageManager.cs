using System.Threading.Tasks;

namespace RuiChen.Platform.Messages;
public interface ISmsMessageManager
{
    Task<SmsMessage> SendAsync(SmsMessage message);
}
