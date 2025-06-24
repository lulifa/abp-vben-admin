using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RuiChen.Single.HttpApi.Host;

public class TenantHeaderParamter : IOperationFilter
{
    private readonly AbpMultiTenancyOptions _multiTenancyOptions;
    private readonly AbpAspNetCoreMultiTenancyOptions _aspNetCoreMultiTenancyOptions;
    public TenantHeaderParamter(
        IOptions<AbpMultiTenancyOptions> multiTenancyOptions,
        IOptions<AbpAspNetCoreMultiTenancyOptions> aspNetCoreMultiTenancyOptions)
    {
        _multiTenancyOptions = multiTenancyOptions.Value;
        _aspNetCoreMultiTenancyOptions = aspNetCoreMultiTenancyOptions.Value;
    }

    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (_multiTenancyOptions.IsEnabled)
        {
            operation.Parameters = operation.Parameters ?? new List<OpenApiParameter>();
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = _aspNetCoreMultiTenancyOptions.TenantKey,
                In = ParameterLocation.Header,
                Description = "Tenant Id in http header",
                Required = false
            });
        }
    }
}
