﻿using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace RuiChen.Platform.Feedbacks;
public interface IFeedbackAppService : IApplicationService
{
    Task<FeedbackDto> GetAsync(Guid id);

    Task<FeedbackDto> CreateAsync(FeedbackCreateDto input);

    Task DeleteAsync(Guid id);

    Task<PagedResultDto<FeedbackDto>> GetListAsync(FeedbackGetListInput input);
}
