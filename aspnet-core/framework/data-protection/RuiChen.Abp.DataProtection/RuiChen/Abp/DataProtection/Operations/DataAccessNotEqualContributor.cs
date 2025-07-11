﻿using System.Linq.Expressions;

namespace RuiChen.Abp.DataProtection.Operations;
public class DataAccessNotEqualContributor : IDataAccessOperateContributor
{
    public DataAccessFilterOperate Operate => DataAccessFilterOperate.NotEqual;

    public Expression BuildExpression(Expression left, Expression right)
    {
        return Expression.NotEqual(left, right);
    }
}
