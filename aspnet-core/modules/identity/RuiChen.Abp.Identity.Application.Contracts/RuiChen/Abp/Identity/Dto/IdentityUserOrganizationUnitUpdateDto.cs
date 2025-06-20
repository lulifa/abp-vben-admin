using System;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.Identity;

public class IdentityUserOrganizationUnitUpdateDto
{
    [Required]
    public Guid[] OrganizationUnitIds { get; set; }
}
