using System.Threading.Tasks;

namespace RuiChen.Abp.OssManagement;

public interface IFileValidater
{
    Task ValidationAsync(UploadFile input);
}
