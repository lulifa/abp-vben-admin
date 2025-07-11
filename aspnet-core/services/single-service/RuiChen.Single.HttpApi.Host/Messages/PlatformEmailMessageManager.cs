﻿using RuiChen.Platform.Messages;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Emailing;
using Volo.Abp.Settings;

namespace RuiChen.Single.HttpApi.Host;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IEmailMessageManager), typeof(EmailMessageManager))]
public class PlatformEmailMessageManager : EmailMessageManager
{
    public PlatformEmailMessageManager(
        ISettingProvider settingProvider,
        IEmailMessageRepository repository, 
        IBlobContainer<MessagingContainer> blobContainer) 
        : base(settingProvider, repository, blobContainer)
    {
    }

    protected override IEmailSender GetEmailSender()
    {
        return LazyServiceProvider.GetRequiredKeyedService<IEmailSender>("DefaultEmailSender");
    }
}
