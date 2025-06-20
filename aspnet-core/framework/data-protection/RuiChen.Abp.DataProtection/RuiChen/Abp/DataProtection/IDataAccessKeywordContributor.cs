using System.Linq.Expressions;

namespace RuiChen.Abp.DataProtection;
public interface IDataAccessKeywordContributor
{
    bool IsExternal { get; }

    string Keyword { get; }

    Expression Contribute(DataAccessKeywordContributorContext context);
}
