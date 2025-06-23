using Volo.Abp.Data;

namespace RuiChen.Abp.DataProtectionManagement;

public static class DataProtectionManagementDbProterties
{
    public static string DbTablePrefix { get; set; } = AbpCommonDbProperties.DbTablePrefix + "Auth";

    public static string DbSchema { get; set; } = null;


    public const string ConnectionStringName = "AbpDataProtectionManagement";
}
