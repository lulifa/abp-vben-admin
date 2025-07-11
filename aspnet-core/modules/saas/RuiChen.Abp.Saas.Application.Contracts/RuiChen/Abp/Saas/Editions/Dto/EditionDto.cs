﻿using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace RuiChen.Abp.Saas.Editions;

public class EditionDto : ExtensibleAuditedEntityDto<Guid>, IHasConcurrencyStamp
{
    public string DisplayName { get; set; }
    public string ConcurrencyStamp { get; set; }
}
