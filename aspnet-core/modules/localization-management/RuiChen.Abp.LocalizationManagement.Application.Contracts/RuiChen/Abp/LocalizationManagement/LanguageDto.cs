﻿using System;
using Volo.Abp.Application.Dtos;

namespace RuiChen.Abp.LocalizationManagement;
public class LanguageDto : AuditedEntityDto<Guid>
{
    public string CultureName { get; set; }
    public string UiCultureName { get; set; }
    public string DisplayName { get; set; }
    public string TwoLetterISOLanguageName { get; set; }
}
