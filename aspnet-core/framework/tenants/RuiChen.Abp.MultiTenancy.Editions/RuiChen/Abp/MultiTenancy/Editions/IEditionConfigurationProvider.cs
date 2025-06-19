using System;
using System.Threading.Tasks;

namespace RuiChen.Abp.MultiTenancy.Editions;

public interface IEditionConfigurationProvider
{
    Task<EditionConfiguration> GetAsync(Guid? tenantId = null);
}
