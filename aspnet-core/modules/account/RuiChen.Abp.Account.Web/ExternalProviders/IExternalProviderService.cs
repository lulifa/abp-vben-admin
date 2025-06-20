using RuiChen.Abp.Account.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RuiChen.Abp.Account.Web.ExternalProviders;

public interface IExternalProviderService
{
    Task<List<ExternalLoginProviderModel>> GetAllAsync();
}
