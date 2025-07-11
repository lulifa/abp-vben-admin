﻿using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.TextTemplating;

namespace RuiChen.Abp.TextTemplating;

public class TextTemplateContentContributor : ITemplateContentContributor, ITransientDependency
{
    protected AbpTextTemplatingCachingOptions TemplatingCachingOptions { get; }
    protected IDistributedCache<TextTemplateContentCacheItem> TextTemplateContentCache { get; }

    public TextTemplateContentContributor(
        IDistributedCache<TextTemplateContentCacheItem> textTemplateContentCache,
        IOptions<AbpTextTemplatingCachingOptions> templatingCachingOptions)
    {
        TextTemplateContentCache = textTemplateContentCache;
        TemplatingCachingOptions = templatingCachingOptions.Value;
    }

    public async virtual Task<string> GetOrNullAsync(TemplateContentContributorContext context)
    {
        // 2024/05/27 fixed 内联本地化不需要多语言
        var culture = context.TemplateDefinition.IsInlineLocalized ? null : context.Culture;

        var cacheKey = TextTemplateContentCacheItem.CalculateCacheKey(context.TemplateDefinition.Name, culture);

        var cacheItem = await TextTemplateContentCache.GetOrAddAsync(cacheKey,
            () => CreateTemplateContentCache(context),
            () => CreateTemplateContentCacheOptions());

        return cacheItem?.Content;
    }

    protected async virtual Task<TextTemplateContentCacheItem> CreateTemplateContentCache(TemplateContentContributorContext context)
    {
        // 2024/05/27 fixed 内联本地化不需要多语言
        var culture = context.TemplateDefinition.IsInlineLocalized ? null : context.Culture;
        var repository = context.ServiceProvider.GetRequiredService<ITextTemplateRepository>();
        var template = await repository.FindByNameAsync(context.TemplateDefinition.Name, culture);

        // 2025/06/23 fixed 非内联本地化模板内容为空时,回退到默认文化
        if (template == null && !culture.IsNullOrWhiteSpace())
        {
            template = await repository.FindByNameAsync(context.TemplateDefinition.Name, context.TemplateDefinition.DefaultCultureName);
        }

        return new TextTemplateContentCacheItem(
            template?.Name,
            template?.Content,
            template?.Culture);
    }

    protected DistributedCacheEntryOptions CreateTemplateContentCacheOptions()
    {
        return new DistributedCacheEntryOptions
        {
            SlidingExpiration = TemplatingCachingOptions.MinimumCacheDuration,
            AbsoluteExpirationRelativeToNow = TemplatingCachingOptions.MaximumCacheDuration,
        };
    }
}
