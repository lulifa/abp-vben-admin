using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.CachingManagement;

public class CacheKeyInput
{
    [Required]
    public string Key { get; set; }
}
