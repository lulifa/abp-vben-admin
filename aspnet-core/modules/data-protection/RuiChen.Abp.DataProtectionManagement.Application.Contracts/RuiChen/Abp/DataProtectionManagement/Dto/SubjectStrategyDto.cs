using RuiChen.Abp.DataProtection;

namespace RuiChen.Abp.DataProtectionManagement;

public class SubjectStrategyDto
{
    public bool IsEnabled { get; set; }
    public string SubjectName { get; set; }
    public string SubjectId { get; set; }
    public DataAccessStrategy Strategy { get; set; }
}
