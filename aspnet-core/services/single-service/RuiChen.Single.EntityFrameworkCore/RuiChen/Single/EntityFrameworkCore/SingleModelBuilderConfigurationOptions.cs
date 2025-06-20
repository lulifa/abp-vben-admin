using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace RuiChen.Single.EntityFrameworkCore;

public class SingleModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
{
    public SingleModelBuilderConfigurationOptions(
        [NotNull] string tablePrefix = "",
        [CanBeNull] string? schema = null)
        : base(
            tablePrefix,
            schema)
    {

    }
}
