﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.MessageService.Groups;

public class GroupAcceptUserDto
{
    [Required]
    public Guid UserId { get; set; }

    [Required]
    public long GroupId { get; set; }

    public bool AllowAccept { get; set; } = true;

    [StringLength(64)]
    public string RejectReason { get; set; }
}
