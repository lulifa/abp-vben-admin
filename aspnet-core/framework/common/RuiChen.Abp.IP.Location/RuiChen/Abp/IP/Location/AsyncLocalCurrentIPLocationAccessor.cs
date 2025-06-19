﻿using System.Threading;

namespace RuiChen.Abp.IP.Location;
public class AsyncLocalCurrentIPLocationAccessor : ICurrentIPLocationAccessor
{
    public static AsyncLocalCurrentIPLocationAccessor Instance { get; } = new();

    public IPLocation? Current {
        get => _currentScope.Value;
        set => _currentScope.Value = value;
    }

    private readonly AsyncLocal<IPLocation?> _currentScope;

    private AsyncLocalCurrentIPLocationAccessor()
    {
        _currentScope = new AsyncLocal<IPLocation?>();
    }
}
