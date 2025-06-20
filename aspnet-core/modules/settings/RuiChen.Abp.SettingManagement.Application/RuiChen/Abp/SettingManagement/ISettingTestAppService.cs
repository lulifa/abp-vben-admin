﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RuiChen.Abp.SettingManagement;

public interface ISettingTestAppService
{
    Task SendTestEmailAsync(SendTestEmailInput input);
}

public class SendTestEmailInput
{
    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }
}
