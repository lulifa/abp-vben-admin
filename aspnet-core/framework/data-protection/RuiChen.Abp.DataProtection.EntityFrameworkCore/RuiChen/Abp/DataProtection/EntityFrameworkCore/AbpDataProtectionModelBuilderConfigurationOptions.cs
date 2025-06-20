using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace RuiChen.Abp.DataProtection.EntityFrameworkCore
{
    public class AbpDataProtectionModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AbpDataProtectionModelBuilderConfigurationOptions(
           [NotNull] string tablePrefix = "",
           [CanBeNull] string schema = null)
           : base(
               tablePrefix,
               schema)
        {

        }
    }
}
