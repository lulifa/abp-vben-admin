﻿using System;
using System.Threading.Tasks;

namespace RuiChen.Abp.Account.Emailing;

public interface IAccountEmailConfirmSender
{
    Task SendEmailConfirmLinkAsync(
        Guid userId,
        string userEmail,
        string confirmToken,
        string appName,
        string returnUrl = null,
        string returnUrlHash = null,
        Guid? userTenantId = null
    );
}
