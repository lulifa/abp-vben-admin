﻿using JetBrains.Annotations;
using RuiChen.Platform.Routes;
using System;

namespace RuiChen.Platform.Layouts;

/// <summary>
/// 布局视图实体
/// </summary>
public class Layout : Route
{
    /// <summary>
    /// 框架
    /// </summary>
    public virtual string Framework { get; protected set; }
    /// <summary>
    /// 约定的Meta采用哪种数据字典,主要是约束路由必须字段的一致性
    /// </summary>
    public virtual Guid DataId { get; protected set; }

    protected Layout() { }

    public Layout(
        [NotNull] Guid id, 
        [NotNull] string path, 
        [NotNull] string name,
        [NotNull] string displayName,
        [NotNull] Guid dataId,
        [NotNull] string framework,
        [CanBeNull] string redirect = "",
        [CanBeNull] string description = "",
        [CanBeNull] Guid? tenantId = null) 
        : base(id, path, name, displayName, redirect, description, tenantId)
    {
        DataId = dataId;
        Framework = framework;
    }
}
