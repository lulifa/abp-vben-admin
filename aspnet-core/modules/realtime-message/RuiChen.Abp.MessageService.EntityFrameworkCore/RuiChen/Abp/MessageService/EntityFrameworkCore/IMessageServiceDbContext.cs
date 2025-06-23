using RuiChen.Abp.MessageService.Chat;
using RuiChen.Abp.MessageService.Groups;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace RuiChen.Abp.MessageService.EntityFrameworkCore;

[ConnectionStringName(AbpMessageServiceDbProperties.ConnectionStringName)]
public interface IMessageServiceDbContext : IEfCoreDbContext
{
    DbSet<UserMessage> UserMessages { get; }
    DbSet<GroupMessage> GroupMessages { get; }
    DbSet<UserChatFriend> UserChatFriends { get; }
    DbSet<UserChatSetting> UserChatSettings { get; }
    DbSet<GroupChatBlack> GroupChatBlacks { get; }
    DbSet<ChatGroup> ChatGroups { get; }
    DbSet<UserChatGroup> UserChatGroups { get; }
    DbSet<UserChatCard> UserChatCards { get; }
    DbSet<UserGroupCard> UserGroupCards { get; }
}
