using System.Threading.Tasks;

namespace RuiChen.Abp.Account.Emailing;

public interface IAccountEmailVerifySender
{
    Task SendMailLoginVerifyCodeAsync(
        string code,
        string userName,
        string emailAddress);
}
