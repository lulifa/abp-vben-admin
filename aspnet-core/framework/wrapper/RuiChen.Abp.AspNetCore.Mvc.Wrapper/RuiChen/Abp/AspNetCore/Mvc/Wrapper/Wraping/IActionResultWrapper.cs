using Microsoft.AspNetCore.Mvc.Filters;

namespace RuiChen.Abp.AspNetCore.Mvc.Wrapper.Wraping;

public interface IActionResultWrapper
{
    void Wrap(FilterContext context);
}
