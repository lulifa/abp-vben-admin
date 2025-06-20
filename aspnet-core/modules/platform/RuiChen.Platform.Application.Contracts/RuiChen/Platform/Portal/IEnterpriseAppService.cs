using System;
using Volo.Abp.Application.Services;

namespace RuiChen.Platform.Portal;

public interface IEnterpriseAppService :
    ICrudAppService<
        EnterpriseDto,
        Guid,
        EnterpriseGetListInput,
        EnterpriseCreateDto,
        EnterpriseUpdateDto>
{
}
