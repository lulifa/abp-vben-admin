using NRules.Extensibility;
using NRules.RuleModel;
using System.Collections.Generic;

namespace RuiChen.Abp.Rules.NRules;

public class ActionInterceptor : IActionInterceptor
{
    public void Intercept(IContext context, IEnumerable<IActionInvocation> actions)
    {
        // TODO: Intercept
    }
}
