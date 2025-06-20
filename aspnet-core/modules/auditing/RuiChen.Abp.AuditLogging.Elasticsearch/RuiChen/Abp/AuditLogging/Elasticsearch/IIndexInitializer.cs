using System.Threading.Tasks;

namespace RuiChen.Abp.AuditLogging.Elasticsearch;

public interface IIndexInitializer
{
    Task InitializeAsync();
}
