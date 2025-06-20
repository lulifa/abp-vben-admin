using System;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.Account;

public class GetTwoFactorProvidersInput
{
    [Required]
    public Guid UserId { get; set; }
}
