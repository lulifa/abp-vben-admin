using RuiChen.Platform.Datas;
using RuiChen.Platform.Layouts;
using RuiChen.Platform.Menus;
using RuiChen.Platform.Messages;
using RuiChen.Platform.Packages;
using RuiChen.Platform.Portal;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace RuiChen.Platform.EntityFrameworkCore;

[ConnectionStringName(PlatformDbProperties.ConnectionStringName)]
public interface IPlatformDbContext : IEfCoreDbContext
{
    DbSet<Menu> Menus { get; }
    DbSet<Layout> Layouts { get; }
    DbSet<RoleMenu> RoleMenus { get; }
    DbSet<UserMenu> UserMenus { get; }
    DbSet<UserFavoriteMenu> UserFavoriteMenus { get; }
    DbSet<Data> Datas { get; }
    DbSet<DataItem> DataItems { get; }
    DbSet<Package> Packages { get; }
    DbSet<PackageBlob> PackageBlobs { get; }
    DbSet<Enterprise> Enterprises { get; }
    DbSet<EmailMessage> EmailMessages { get; }
    DbSet<SmsMessage> SmsMessages { get; }
}
