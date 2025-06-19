using System;

namespace RuiChen.Abp.Wrapper;

public interface IExceptionWrapHandlerFactory
{
    IExceptionWrapHandler CreateFor(ExceptionWrapContext context);
}
