using System.Threading.Tasks;

namespace RuiChen.Abp.IM.Messages;

public interface IMessageSenderProvider
{
    string Name { get; }
    Task SendMessageAsync(ChatMessage chatMessage);
}
