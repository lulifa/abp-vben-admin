using Volo.Abp.Domain.Entities;

namespace RuiChen.Platform.Feedbacks;
public class FeedbackCommentUpdateDto : FeedbackCommentCreateOrUpdateDto, IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}
