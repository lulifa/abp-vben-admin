using System.Threading.Tasks;

namespace RuiChen.Abp.IM.Messages;

public interface IMessageSender
{
    Task<string> SendMessageAsync(ChatMessage chatMessage);
}
