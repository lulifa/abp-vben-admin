using System.Threading.Tasks;
using Volo.Abp.Users;

namespace RuiChen.Abp.MessageService.Chat;

public interface IChatDataSeeder
{
    Task SeedAsync(IUserData user);
}
