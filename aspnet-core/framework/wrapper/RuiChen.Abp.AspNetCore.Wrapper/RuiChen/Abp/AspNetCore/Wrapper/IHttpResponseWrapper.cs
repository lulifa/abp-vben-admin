namespace RuiChen.Abp.AspNetCore.Wrapper;
public interface IHttpResponseWrapper
{
    void Wrap(HttpResponseWrapperContext context);
}
