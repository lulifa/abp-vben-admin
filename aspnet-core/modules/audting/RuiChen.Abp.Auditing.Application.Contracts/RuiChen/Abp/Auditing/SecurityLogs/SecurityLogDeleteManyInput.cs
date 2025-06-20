using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.Auditing.SecurityLogs;
public class SecurityLogDeleteManyInput
{
    [Required]
    public List<Guid> Ids { get; set; }
}
