using System.Threading;
using System.Threading.Tasks;

namespace RuiChen.Abp.OssManagement;

public interface IFileUploader
{
    Task UploadAsync(UploadFileChunkInput input, CancellationToken cancellationToken = default);
}
