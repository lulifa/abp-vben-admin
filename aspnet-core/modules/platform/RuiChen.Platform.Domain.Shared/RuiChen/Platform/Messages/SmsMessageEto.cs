using Volo.Abp.EventBus;

namespace RuiChen.Platform.Messages;

[EventName("platform.messages.sms")]
public class SmsMessageEto : MessageEto
{
}
