using System;

namespace RuiChen.Abp.DataProtection;

public interface IJavaScriptTypeConvert
{
    JavaScriptTypeConvertResult Convert(Type propertyType);
}
