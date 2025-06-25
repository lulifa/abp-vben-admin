﻿using System.ComponentModel.DataAnnotations;
using Volo.Abp.Validation;

namespace RuiChen.Abp.TextTemplating;

public class TextTemplateContentGetInput
{
    [Required]
    [DynamicStringLength(typeof(TextTemplateConsts), nameof(TextTemplateConsts.MaxNameLength))]
    public string Name { get; set; }

    [DynamicStringLength(typeof(TextTemplateConsts), nameof(TextTemplateConsts.MaxCultureLength))]
    public string Culture { get; set; }
}
