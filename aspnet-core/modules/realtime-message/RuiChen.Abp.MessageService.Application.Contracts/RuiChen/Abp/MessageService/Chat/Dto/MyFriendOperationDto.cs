﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RuiChen.Abp.MessageService.Chat;

public class MyFriendOperationDto
{
    [Required]
    public Guid FriendId { get; set; }
}
