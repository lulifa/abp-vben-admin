﻿using RuiChen.Abp.MessageService.Chat;
using RuiChen.Abp.MessageService.Groups;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace RuiChen.Abp.MessageService.EntityFrameworkCore;

[ConnectionStringName(AbpMessageServiceDbProperties.ConnectionStringName)]
public class MessageServiceDbContext : AbpDbContext<MessageServiceDbContext>, IMessageServiceDbContext
{
    public DbSet<UserMessage> UserMessages { get; set; }
    public DbSet<GroupMessage> GroupMessages { get; set; }
    public DbSet<UserChatFriend> UserChatFriends { get; set; }
    public DbSet<UserChatSetting> UserChatSettings { get; set; }
    public DbSet<GroupChatBlack> GroupChatBlacks { get; set; }
    public DbSet<ChatGroup> ChatGroups { get; set; }
    public DbSet<UserChatGroup> UserChatGroups { get; set; }
    public DbSet<UserChatCard> UserChatCards { get; set; }
    public DbSet<UserGroupCard> UserGroupCards { get; set; }

    public MessageServiceDbContext(DbContextOptions<MessageServiceDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureMessageService(options =>
        {
            options.TablePrefix = AbpMessageServiceDbProperties.DefaultTablePrefix;
            options.Schema = AbpMessageServiceDbProperties.DefaultSchema;
        });
    }
}
