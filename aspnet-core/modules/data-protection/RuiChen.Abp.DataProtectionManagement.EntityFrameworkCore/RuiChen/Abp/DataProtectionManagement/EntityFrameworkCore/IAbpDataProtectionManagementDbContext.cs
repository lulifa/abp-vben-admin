using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace RuiChen.Abp.DataProtectionManagement.EntityFrameworkCore;

public interface IAbpDataProtectionManagementDbContext : IEfCoreDbContext
{
    DbSet<EntityTypeInfo> EntityTypeInfos { get; set; }
}
