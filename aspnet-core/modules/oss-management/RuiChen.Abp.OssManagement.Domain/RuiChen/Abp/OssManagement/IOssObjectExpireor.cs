using System.Threading.Tasks;

namespace RuiChen.Abp.OssManagement;
public interface IOssObjectExpireor
{
    Task ExpireAsync(ExprieOssObjectRequest request);
}
