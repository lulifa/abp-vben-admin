using System.Linq.Expressions;

namespace RuiChen.Abp.DataProtection.Operations;
public class DataAccessLessOrEqualContributor : IDataAccessOperateContributor
{
    public DataAccessFilterOperate Operate => DataAccessFilterOperate.LessOrEqual;

    public Expression BuildExpression(Expression left, Expression right)
    {
        return Expression.LessThanOrEqual(left, right);
    }
}
