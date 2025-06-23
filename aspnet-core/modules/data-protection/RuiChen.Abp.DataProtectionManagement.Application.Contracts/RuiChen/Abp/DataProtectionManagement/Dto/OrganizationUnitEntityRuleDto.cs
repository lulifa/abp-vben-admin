using System;

namespace RuiChen.Abp.DataProtectionManagement;
public class OrganizationUnitEntityRuleDto : EntityRuleDtoBase
{
    public Guid OrgId { get; set; }
    public string OrgCode { get; set; }
}
