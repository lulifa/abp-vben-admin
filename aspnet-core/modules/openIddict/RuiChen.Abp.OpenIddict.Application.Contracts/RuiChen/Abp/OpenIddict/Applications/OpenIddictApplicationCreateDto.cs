﻿using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.OpenIddict.Applications;
using Volo.Abp.Validation;

namespace RuiChen.Abp.OpenIddict.Applications;

[Serializable]
public class OpenIddictApplicationCreateDto : OpenIddictApplicationCreateOrUpdateDto
{
    [Required]
    [DynamicStringLength(typeof(OpenIddictApplicationConsts), nameof(OpenIddictApplicationConsts.ClientIdMaxLength))]
    public string ClientId { get; set; }
}
