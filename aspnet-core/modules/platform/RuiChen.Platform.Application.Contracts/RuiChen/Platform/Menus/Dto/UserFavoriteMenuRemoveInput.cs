using System;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Platform.Menus;
public class UserFavoriteMenuRemoveInput
{
    [Required]
    public Guid MenuId { get; set; }
}
