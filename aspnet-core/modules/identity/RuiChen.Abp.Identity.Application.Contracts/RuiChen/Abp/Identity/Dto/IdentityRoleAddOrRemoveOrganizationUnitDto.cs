using System;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.Identity;

public class IdentityRoleAddOrRemoveOrganizationUnitDto
{
    [Required]
    public Guid[] OrganizationUnitIds { get; set; }
}
