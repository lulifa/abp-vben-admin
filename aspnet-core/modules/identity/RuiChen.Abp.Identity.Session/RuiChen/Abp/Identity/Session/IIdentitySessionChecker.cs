﻿using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace RuiChen.Abp.Identity.Session;
public interface IIdentitySessionChecker
{
    Task<bool> ValidateSessionAsync(ClaimsPrincipal claimsPrincipal, CancellationToken cancellationToken = default);
}
