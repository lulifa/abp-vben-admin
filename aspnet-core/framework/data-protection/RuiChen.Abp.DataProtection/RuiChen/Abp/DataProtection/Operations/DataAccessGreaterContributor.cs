﻿using System.Linq.Expressions;

namespace RuiChen.Abp.DataProtection.Operations;
public class DataAccessGreaterContributor : IDataAccessOperateContributor
{
    public DataAccessFilterOperate Operate => DataAccessFilterOperate.Greater;

    public Expression BuildExpression(Expression left, Expression right)
    {
        return Expression.GreaterThan(left, right);
    }
}
