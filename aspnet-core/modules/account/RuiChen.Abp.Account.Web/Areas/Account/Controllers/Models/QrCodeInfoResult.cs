using RuiChen.Abp.Identity.QrCode;

namespace RuiChen.Abp.Account.Web.Areas.Account.Controllers.Models;

public class QrCodeInfoResult
{
    public string Key { get; set; }
    public QrCodeStatus Status { get; set; }
}
