using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Platform.Feedbacks;
public class FeedbackCommentDto : AuditedEntityDto<Guid>
{
    public string Content { get; set; }
}
