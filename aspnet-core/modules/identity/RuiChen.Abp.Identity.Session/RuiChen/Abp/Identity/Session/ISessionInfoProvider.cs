using System;

namespace RuiChen.Abp.Identity.Session;
public interface ISessionInfoProvider
{
    string SessionId { get; }

    IDisposable Change(string sessionId);
}
