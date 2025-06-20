using System.Linq.Expressions;

namespace RuiChen.Abp.DataProtection.Operations;
public class DataAccessGreaterOrEqualContributor : IDataAccessOperateContributor
{
    public DataAccessFilterOperate Operate => DataAccessFilterOperate.GreaterOrEqual;

    public Expression BuildExpression(Expression left, Expression right)
    {
        return Expression.GreaterThanOrEqual(left, right);
    }
}
