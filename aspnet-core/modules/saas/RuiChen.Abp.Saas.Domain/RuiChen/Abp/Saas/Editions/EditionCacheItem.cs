using RuiChen.Abp.MultiTenancy.Editions;
using System;
using Volo.Abp.MultiTenancy;

namespace RuiChen.Abp.Saas.Editions;

[Serializable]
[IgnoreMultiTenancy]
public class EditionCacheItem
{
    private const string CacheKeyFormat = "t:{0}";

    public EditionInfo Value { get; set; }

    public EditionCacheItem()
    {

    }

    public EditionCacheItem(EditionInfo value)
    {
        Value = value;
    }

    public static string CalculateCacheKey(Guid tenantId)
    {
        return string.Format(CacheKeyFormat, tenantId.ToString());
    }
}
