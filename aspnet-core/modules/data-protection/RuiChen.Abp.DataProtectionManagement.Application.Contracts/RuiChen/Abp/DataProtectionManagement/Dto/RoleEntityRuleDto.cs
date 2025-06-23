using System;

namespace RuiChen.Abp.DataProtectionManagement;

public class RoleEntityRuleDto : EntityRuleDtoBase
{
    public Guid RoleId { get; set; }
    public string RoleName { get; set; }
}
