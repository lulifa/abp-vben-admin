﻿using System.ComponentModel;

namespace RuiChen.Abp.DataProtection;
/// <summary>
/// 数据过滤连接方式
/// </summary>
public enum DataAccessFilterLogic
{
    /// <summary>
    /// 且
    /// </summary>
    [Description("且")]
    And,
    /// <summary>
    /// 或
    /// </summary>
    [Description("或")]
    Or
}