﻿using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace RuiChen.Abp.MessageService.ObjectExtending;

public class MessageServiceModuleExtensionConfiguration : ModuleExtensionConfiguration
{
    public MessageServiceModuleExtensionConfiguration ConfigureMessage(
        Action<EntityExtensionConfiguration> configureAction)
    {
        return this.ConfigureEntity(
            MessageServiceModuleExtensionConsts.EntityNames.Message,
            configureAction
        );
    }
}
