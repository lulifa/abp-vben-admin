using Volo.Abp.ObjectExtending;

namespace RuiChen.Abp.Identity;

public class OrganizationUnitUpdateDto : ExtensibleObject
{
    public string DisplayName { get; set; }
}
