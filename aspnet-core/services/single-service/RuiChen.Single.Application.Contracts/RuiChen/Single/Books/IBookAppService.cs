using RuiChen.Abp.DataProtection.Models;
using RuiChen.Abp.Exporter;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace RuiChen.Single.Books;
public interface IBookAppService :
    IApplicationService,
    IExporterAppService<BookDto, BookExportListInput>,
    IImporterAppService<BookImportInput>
{
    Task<BookDto> CreateAsync(CreateBookDto input);

    Task<BookDto> UpdateAsync(Guid id, UpdateBookDto input);

    Task<BookDto> GetAsync(Guid id);

    Task DeleteAsync(Guid id);

    Task<PagedResultDto<BookDto>> GetListAsync(BookGetListInput input);

    Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
    /// <summary>
    /// 获取实体可访问规则
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<EntityTypeInfoModel> GetEntityRuleAsync(EntityTypeInfoGetModel input);
}