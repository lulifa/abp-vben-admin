using System;
using System.Threading.Tasks;

namespace RuiChen.Abp.MessageService;

public interface IMessageDataSeeder
{
    Task SeedAsync(Guid? tenantId = null);
}
