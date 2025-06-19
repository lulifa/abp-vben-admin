using System.Threading.Tasks;

namespace RuiChen.Abp.EventBus.CAP;

public interface IFailedThresholdCallbackNotifier
{
    Task NotifyAsync(AbpCAPExecutionFailedException exception);
}
