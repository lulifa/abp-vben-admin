﻿using System;

namespace RuiChen.Abp.DataProtection;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
public class DisableDataProtectedAttribute : Attribute
{
    public DisableDataProtectedAttribute()
    {
    }
}
