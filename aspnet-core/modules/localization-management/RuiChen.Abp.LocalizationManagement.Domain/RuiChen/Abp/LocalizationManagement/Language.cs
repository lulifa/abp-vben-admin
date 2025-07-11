﻿using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Localization;

namespace RuiChen.Abp.LocalizationManagement;

public class Language : AuditedEntity<Guid>, ILanguageInfo
{
    public virtual bool Enable { get; set; }
    public virtual string CultureName { get; protected set; }
    public virtual string UiCultureName { get; protected set; }
    public virtual string DisplayName { get; protected set; }
    public virtual string TwoLetterISOLanguageName { get; set; }
    protected Language() { }
    public Language(
        Guid id,
        [NotNull] string cultureName,
        [NotNull] string uiCultureName,
        [NotNull] string displayName,
        string twoLetterISOLanguageName = null)
        : base(id)
    {
        CultureName = Check.NotNullOrWhiteSpace(cultureName, nameof(cultureName), LanguageConsts.MaxCultureNameLength);
        UiCultureName = Check.NotNullOrWhiteSpace(uiCultureName, nameof(uiCultureName), LanguageConsts.MaxUiCultureNameLength);
        DisplayName = Check.NotNullOrWhiteSpace(displayName, nameof(displayName), LanguageConsts.MaxDisplayNameLength);
        TwoLetterISOLanguageName = Check.Length(twoLetterISOLanguageName, nameof(twoLetterISOLanguageName), LanguageConsts.MaxTwoLetterISOLanguageNameLength);

        Enable = true;
    }

    public virtual void SetDisplayName(string displayName)
    {
        DisplayName = Check.NotNullOrWhiteSpace(displayName, nameof(displayName), LanguageConsts.MaxDisplayNameLength);
    }

    public virtual void SetTwoLetterISOLanguageName(string twoLetterISOLanguageName)
    {
        TwoLetterISOLanguageName = Check.Length(twoLetterISOLanguageName, nameof(twoLetterISOLanguageName), LanguageConsts.MaxTwoLetterISOLanguageNameLength);
    }

    public virtual void ChangeCulture(string cultureName, string uiCultureName = null, string displayName = null)
    {
        ChangeCultureInternal(cultureName, uiCultureName, displayName);
    }

    private void ChangeCultureInternal(string cultureName, string uiCultureName, string displayName)
    {
        CultureName = Check.NotNullOrWhiteSpace(cultureName, nameof(cultureName), LanguageConsts.MaxCultureNameLength);

        UiCultureName = !uiCultureName.IsNullOrWhiteSpace()
            ? Check.Length(uiCultureName, nameof(uiCultureName), LanguageConsts.MaxUiCultureNameLength)
            : cultureName;

        DisplayName = !displayName.IsNullOrWhiteSpace()
            ? Check.Length(displayName, nameof(displayName), LanguageConsts.MaxDisplayNameLength)
            : cultureName;
    }
}
