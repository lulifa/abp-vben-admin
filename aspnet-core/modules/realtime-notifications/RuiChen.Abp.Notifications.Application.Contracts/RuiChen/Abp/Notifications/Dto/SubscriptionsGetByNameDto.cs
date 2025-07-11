﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.Notifications;

public class SubscriptionsGetByNameDto
{
    [Required]
    [StringLength(NotificationConsts.MaxNameLength)]
    [DisplayName("Notifications:Name")]
    public string Name { get; set; }
}
