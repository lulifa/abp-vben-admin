using RuiChen.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.Authenticator;
using RuiChen.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.SecurityLog;
using RuiChen.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.Session;
using RuiChen.Abp.Account.Web.Pages.Account.Components.ProfileManagementGroup.TwoFactor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Volo.Abp.Account.Localization;
using Volo.Abp.Account.Web.ProfileManagement;

namespace RuiChen.Abp.Account.Web.ProfileManagement;

public class ProfileManagementPageContributor : IProfileManagementPageContributor
{
    public virtual Task ConfigureAsync(ProfileManagementPageCreationContext context)
    {
        var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<AccountResource>>();

        context.Groups.Add(
            new ProfileManagementPageGroup(
                "RuiChen.Abp.Account.Session",
                l["ProfileTab:Session"],
                typeof(AccountProfileSessionManagementGroupViewComponent)
            )
        );

        context.Groups.Add(
            new ProfileManagementPageGroup(
                "RuiChen.Abp.Account.TwoFactor",
                l["ProfileTab:TwoFactor"],
                typeof(AccountProfileTwoFactorManagementGroupViewComponent)
            )
        );

        context.Groups.Add(
            new ProfileManagementPageGroup(
                "RuiChen.Abp.Account.SecurityLog",
                l["ProfileTab:SecurityLog"],
                typeof(AccountProfileSecurityLogManagementGroupViewComponent)
            )
        );

        context.Groups.Add(
            new ProfileManagementPageGroup(
                "RuiChen.Abp.Account.Authenticator",
                l["ProfileTab:Authenticator"],
                typeof(AccountProfileAuthenticatorManagementGroupViewComponent)
            )
        );

        return Task.CompletedTask;
    }
}
