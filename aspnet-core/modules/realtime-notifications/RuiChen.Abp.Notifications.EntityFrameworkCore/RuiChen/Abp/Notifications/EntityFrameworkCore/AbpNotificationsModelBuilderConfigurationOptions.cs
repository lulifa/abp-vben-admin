﻿using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace RuiChen.Abp.Notifications.EntityFrameworkCore;

public class AbpNotificationsModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
{
    public AbpNotificationsModelBuilderConfigurationOptions(
        [NotNull] string tablePrefix = AbpNotificationsDbProperties.DefaultTablePrefix,
        [CanBeNull] string schema = AbpNotificationsDbProperties.DefaultSchema)
        : base(
            tablePrefix,
            schema)
    {

    }
}
