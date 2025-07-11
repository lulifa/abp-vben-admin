﻿using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.Identity;

public class IdentityClaimDto : EntityDto<Guid>
{
    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }
}
