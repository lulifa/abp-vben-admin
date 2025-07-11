﻿using RuiChen.Abp.IM;
using RuiChen.Abp.IM.Messages;
using RuiChen.Abp.RealTime;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;
using Microsoft.Extensions.Logging;

namespace RuiChen.Single.HttpApi.Host
{
    public class ChatMessageEventHandler : IDistributedEventHandler<RealTimeEto<ChatMessage>>, ITransientDependency
    {
        /// <summary>
        /// Reference to <see cref="ILogger<DefaultNotificationDispatcher>"/>.
        /// </summary>
        public ILogger<ChatMessageEventHandler> Logger { get; set; }
        /// <summary>
        /// Reference to <see cref="AbpIMOptions"/>.
        /// </summary>
        protected AbpIMOptions Options { get; }

        protected IMessageStore MessageStore { get; }
        protected IMessageBlocker MessageBlocker { get; }
        protected IMessageSenderProviderManager MessageSenderProviderManager { get; }

        public ChatMessageEventHandler(
            IOptions<AbpIMOptions> options,
            IMessageStore messageStore,
            IMessageBlocker messageBlocker,
            IMessageSenderProviderManager messageSenderProviderManager)
        {
            Options = options.Value;
            MessageStore = messageStore;
            MessageBlocker = messageBlocker;
            MessageSenderProviderManager = messageSenderProviderManager;
            
            Logger = NullLogger<ChatMessageEventHandler>.Instance;
        }

        public async virtual Task HandleEventAsync(RealTimeEto<ChatMessage> eventData)
        {
            Logger.LogDebug($"Persistent chat message.");

            var message = eventData.Data;
            // 消息拦截
            // 扩展敏感词汇过滤
            await MessageBlocker.InterceptAsync(message);

            await MessageStore.StoreMessageAsync(message);

            // 发送消息
            foreach (var provider in MessageSenderProviderManager.Providers)
            {
                Logger.LogDebug($"Sending message with provider {provider.Name}");
                await provider.SendMessageAsync(message);
            }
        }
    }
}
