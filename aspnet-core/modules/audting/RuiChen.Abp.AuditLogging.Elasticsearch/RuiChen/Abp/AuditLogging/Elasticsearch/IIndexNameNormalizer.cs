namespace RuiChen.Abp.AuditLogging.Elasticsearch;

public interface IIndexNameNormalizer
{
    string NormalizeIndex(string index);
}
