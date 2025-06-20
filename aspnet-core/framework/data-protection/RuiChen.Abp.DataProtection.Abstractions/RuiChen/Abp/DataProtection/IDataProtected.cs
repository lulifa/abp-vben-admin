using System;

namespace RuiChen.Abp.DataProtection;

public interface IDataProtected
{
    Guid? CreatorId { get; }
}