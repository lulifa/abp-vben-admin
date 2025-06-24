using System.Threading.Tasks;

namespace RuiChen.Abp.OssManagement;

public interface IOssObjectProcesserContributor
{
    Task ProcessAsync(OssObjectProcesserContext context);
}
