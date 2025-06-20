using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.DataProtection.Models;

public class EntityTypeInfoGetModel
{
    [Required]
    public DataAccessOperation Operation { get; set; }
}
