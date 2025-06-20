using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace RuiChen.Platform.Feedbacks;
public interface IMyFeedbackAppService : IApplicationService
{
    Task<PagedResultDto<FeedbackDto>> GetMyFeedbacksAsync(FeedbackGetListInput input);
}
