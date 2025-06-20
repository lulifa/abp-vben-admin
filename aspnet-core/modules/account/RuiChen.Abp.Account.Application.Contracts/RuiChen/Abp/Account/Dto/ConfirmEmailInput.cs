using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.Account;

public class ConfirmEmailInput
{
    [Required]
    public string ConfirmToken { get; set; }
}
