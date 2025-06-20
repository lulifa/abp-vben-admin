using RuiChen.Abp.DataProtection.Models;
using RuiChen.Single.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Content;
using System.Threading.Tasks;
using System;

namespace RuiChen.Single.Books;

[Controller]
[Authorize(SinglePermissions.Books.Default)]
[RemoteService(Name = SingleRemoteServiceConsts.RemoteServiceName)]
[Area(SingleRemoteServiceConsts.ModuleName)]
[Route($"api/{SingleRemoteServiceConsts.ModuleName}/books")]
public class BookController : AbpControllerBase, IBookAppService
{
    private readonly IBookAppService _service;

    public BookController(IBookAppService service)
    {
        _service = service;
    }

    [HttpPost]
    [Authorize(SinglePermissions.Books.Create)]
    public virtual Task<BookDto> CreateAsync(CreateBookDto input)
    {
        return _service.CreateAsync(input);
    }

    [HttpDelete]
    [Route("{id}")]
    [Authorize(SinglePermissions.Books.Delete)]
    public virtual Task DeleteAsync(Guid id)
    {
        return _service.DeleteAsync(id);
    }

    [HttpPost]
    [Route("import")]
    public virtual Task ImportAsync([FromForm] BookImportInput input)
    {
        return _service.ImportAsync(input);
    }

    [HttpGet]
    [Route("export")]
    public virtual Task<IRemoteStreamContent> ExportAsync(BookExportListInput input)
    {
        return _service.ExportAsync(input);
    }

    [HttpGet]
    [Route("{id}")]
    public virtual Task<BookDto> GetAsync(Guid id)
    {
        return _service.GetAsync(id);
    }

    [HttpGet]
    [Route("lookup")]
    public virtual Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync()
    {
        return _service.GetAuthorLookupAsync();
    }

    [HttpGet]
    public virtual Task<PagedResultDto<BookDto>> GetListAsync(BookGetListInput input)
    {
        return _service.GetListAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    [Authorize(SinglePermissions.Books.Edit)]
    public virtual Task<BookDto> UpdateAsync(Guid id, UpdateBookDto input)
    {
        return _service.UpdateAsync(id, input);
    }

    [HttpGet]
    [Route("entity")]
    public virtual Task<EntityTypeInfoModel> GetEntityRuleAsync(EntityTypeInfoGetModel input)
    {
        return _service.GetEntityRuleAsync(input);
    }
}
