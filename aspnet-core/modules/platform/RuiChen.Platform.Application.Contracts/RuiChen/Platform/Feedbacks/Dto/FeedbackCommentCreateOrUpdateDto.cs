using System.ComponentModel.DataAnnotations;
using Volo.Abp.Validation;

namespace RuiChen.Platform.Feedbacks;
public abstract class FeedbackCommentCreateOrUpdateDto
{
    [Required]
    [DynamicStringLength(typeof(FeedbackCommentConsts), nameof(FeedbackCommentConsts.MaxContentLength))]
    public string Content { get; set; }
}
