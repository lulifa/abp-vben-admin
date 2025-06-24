using System;

namespace RuiChen.Abp.Idempotent;

[AttributeUsage(AttributeTargets.Method)]
public class IgnoreIdempotentAttribute : Attribute
{
}
