using RuiChen.Abp.Saas.MySql;
using RuiChen.Abp.Saas.Oracle;
using RuiChen.Abp.Saas.PostgreSql;
using RuiChen.Abp.Saas.Sqlite;
using RuiChen.Abp.Saas.SqlServer;
using Volo.Abp.Modularity;

namespace RuiChen.Abp.Saas;

[DependsOn(typeof(AbpSaasDomainModule))]
public class AbpSaasDbCheckerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpSaasConnectionStringCheckOptions>(options =>
        {
            options.ConnectionStringCheckers["mysql"] = new MySqlConnectionStringChecker();
            options.ConnectionStringCheckers["oracle"] = new OracleConnectionStringChecker();
            options.ConnectionStringCheckers["postgres"] = new NpgsqlConnectionStringChecker();
            options.ConnectionStringCheckers["sqlite"] = new SqliteConnectionStringChecker();
            options.ConnectionStringCheckers["sqlserver"] = new SqlServerConnectionStringChecker();
        });
    }
}
