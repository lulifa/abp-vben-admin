using RuiChen.Single.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RuiChen.Single.Permissions;
public class SinglePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var demoGroup = context.AddGroup(SinglePermissions.GroupName, L("Permission:Demo"));

        var booksPermission = demoGroup.AddPermission(SinglePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(SinglePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(SinglePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(SinglePermissions.Books.Delete, L("Permission:Books.Delete"));
        booksPermission.AddChild(SinglePermissions.Books.Export, L("Permission:Books.Export"));
        booksPermission.AddChild(SinglePermissions.Books.Import, L("Permission:Books.Import"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SingleResource>(name);
    }
}
