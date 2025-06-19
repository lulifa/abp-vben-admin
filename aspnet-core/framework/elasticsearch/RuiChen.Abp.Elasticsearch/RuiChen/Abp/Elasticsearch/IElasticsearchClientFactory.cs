using Nest;

namespace RuiChen.Abp.Elasticsearch
{
    public interface IElasticsearchClientFactory
    {
        IElasticClient Create();
    }
}
