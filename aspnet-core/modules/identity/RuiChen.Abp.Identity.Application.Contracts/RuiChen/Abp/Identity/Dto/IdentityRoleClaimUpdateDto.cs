﻿using System.ComponentModel.DataAnnotations;
using Volo.Abp.Identity;
using Volo.Abp.Validation;

namespace RuiChen.Abp.Identity;

public class IdentityRoleClaimUpdateDto : IdentityRoleClaimCreateDto
{
    [Required]
    [DynamicMaxLength(typeof(IdentityRoleClaimConsts), nameof(IdentityRoleClaimConsts.MaxClaimValueLength))]
    public string NewClaimValue { get; set; }
}
