﻿using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.OpenIddict.Applications;

[Serializable]
public class OpenIddictApplicationGetListInput : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}
