using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RuiChen.Abp.AspNetCore.Mvc.Wrapper;

public interface IWrapResultChecker
{
    bool WrapOnAction(ActionDescriptor actionDescriptor);

    bool WrapOnExecution(FilterContext context);

    bool WrapOnException(ExceptionContext context);

    bool WrapOnException(PageHandlerExecutedContext context);
}
