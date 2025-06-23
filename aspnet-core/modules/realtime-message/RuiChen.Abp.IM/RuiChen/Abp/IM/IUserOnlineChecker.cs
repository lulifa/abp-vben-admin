﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace RuiChen.Abp.IM;

public interface IUserOnlineChecker
{
    Task<bool> CheckAsync(
        Guid? tenantId,
        Guid userId,
        CancellationToken cancellationToken = default);
}
