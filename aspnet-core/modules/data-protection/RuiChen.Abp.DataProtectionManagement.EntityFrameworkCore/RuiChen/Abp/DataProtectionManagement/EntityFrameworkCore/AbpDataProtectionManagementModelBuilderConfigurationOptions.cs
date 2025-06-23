using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace RuiChen.Abp.DataProtectionManagement.EntityFrameworkCore;

public class AbpDataProtectionManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
{
    public AbpDataProtectionManagementModelBuilderConfigurationOptions(
        [NotNull] string tablePrefix = "",
        [CanBeNull] string schema = null)
        : base(
            tablePrefix,
            schema)
    {

    }
}
