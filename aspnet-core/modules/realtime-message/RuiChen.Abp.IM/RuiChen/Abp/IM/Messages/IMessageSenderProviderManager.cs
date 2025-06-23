using System.Collections.Generic;

namespace RuiChen.Abp.IM.Messages;

public interface IMessageSenderProviderManager
{
    List<IMessageSenderProvider> Providers { get; }
}
