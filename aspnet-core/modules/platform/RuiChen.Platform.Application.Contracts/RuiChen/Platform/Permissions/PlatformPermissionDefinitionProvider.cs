﻿using RuiChen.Platform.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace RuiChen.Platform.Permissions;

public class PlatformPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var platform = context.AddGroup(PlatformPermissions.GroupName, L("Permission:Platform"));

        var dataDictionary = platform.AddPermission(PlatformPermissions.DataDictionary.Default, L("Permission:DataDictionary"));
        dataDictionary.AddChild(PlatformPermissions.DataDictionary.Create, L("Permission:Create"));
        dataDictionary.AddChild(PlatformPermissions.DataDictionary.Update, L("Permission:Update"));
        dataDictionary.AddChild(PlatformPermissions.DataDictionary.Move, L("Permission:Move"));
        dataDictionary.AddChild(PlatformPermissions.DataDictionary.Delete, L("Permission:Delete"));
        dataDictionary.AddChild(PlatformPermissions.DataDictionary.ManageItems, L("Permission:ManageItems"));

        var layout = platform.AddPermission(PlatformPermissions.Layout.Default, L("Permission:Layout"));
        layout.AddChild(PlatformPermissions.Layout.Create, L("Permission:Create"));
        layout.AddChild(PlatformPermissions.Layout.Update, L("Permission:Update"));
        layout.AddChild(PlatformPermissions.Layout.Delete, L("Permission:Delete"));

        var menu = platform.AddPermission(PlatformPermissions.Menu.Default, L("Permission:Menu"));
        menu.AddChild(PlatformPermissions.Menu.Create, L("Permission:Create"));
        menu.AddChild(PlatformPermissions.Menu.Update, L("Permission:Update"));
        menu.AddChild(PlatformPermissions.Menu.Delete, L("Permission:Delete"));
        menu.AddChild(PlatformPermissions.Menu.ManageRoles, L("Permission:ManageRoleMenus"));
        menu.AddChild(PlatformPermissions.Menu.ManageUsers, L("Permission:ManageUserMenus"));
        menu.AddChild(PlatformPermissions.Menu.ManageUserFavorites, L("Permission:ManageUserFavoriteMenus"));

        var package = platform.AddPermission(PlatformPermissions.Package.Default, L("Permission:Package"));
        package.AddChild(PlatformPermissions.Package.Create, L("Permission:Create"));
        package.AddChild(PlatformPermissions.Package.Update, L("Permission:Update"));
        package.AddChild(PlatformPermissions.Package.Delete, L("Permission:Delete"));
        package.AddChild(PlatformPermissions.Package.ManageBlobs, L("Permission:ManageBlobs"));

        var feedback = platform.AddPermission(PlatformPermissions.Feedback.Default, L("Permission:Feedback"));
        feedback.AddChild(PlatformPermissions.Feedback.Create, L("Permission:Create"));
        feedback.AddChild(PlatformPermissions.Feedback.Update, L("Permission:Update"));
        feedback.AddChild(PlatformPermissions.Feedback.Delete, L("Permission:Delete"));
        feedback.AddChild(PlatformPermissions.Feedback.ManageAttachments, L("Permission:ManageAttachments"));
        feedback.AddChild(PlatformPermissions.Feedback.ManageComments, L("Permission:ManageComments"));

        var enterprise = platform.AddPermission(PlatformPermissions.Enterprise.Default, L("Permission:Enterprise"));
        enterprise.AddChild(PlatformPermissions.Enterprise.Create, L("Permission:Create"), MultiTenancySides.Host);
        enterprise.AddChild(PlatformPermissions.Enterprise.Update, L("Permission:Update"), MultiTenancySides.Host);
        enterprise.AddChild(PlatformPermissions.Enterprise.Delete, L("Permission:Delete"), MultiTenancySides.Host);

        var emailMessage = platform.AddPermission(PlatformPermissions.EmailMessage.Default, L("Permission:EmailMessage"));
        emailMessage.AddChild(PlatformPermissions.EmailMessage.SendMessage, L("Permission:SendMessage"));
        emailMessage.AddChild(PlatformPermissions.EmailMessage.Delete, L("Permission:Delete"));

        var smsMessage = platform.AddPermission(PlatformPermissions.SmsMessage.Default, L("Permission:SmsMessage"));
        smsMessage.AddChild(PlatformPermissions.SmsMessage.SendMessage, L("Permission:SendMessage"));
        smsMessage.AddChild(PlatformPermissions.SmsMessage.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PlatformResource>(name);
    }
}
