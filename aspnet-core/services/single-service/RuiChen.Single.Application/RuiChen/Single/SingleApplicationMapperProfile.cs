using AutoMapper;
using RuiChen.Single.Authors;
using RuiChen.Single.Books;
using Volo.Abp.AutoMapper;

namespace RuiChen.Single;
public class SingleApplicationMapperProfile : Profile
{
    public SingleApplicationMapperProfile()
    {
        CreateMap<Book, BookDto>()
            .Ignore(dto => dto.AuthorName);
        CreateMap<BookImportDto, Book>()
            .IgnoreAuditedObjectProperties()
            .Ignore(dto => dto.Id)
            .Ignore(dto => dto.ExtraProperties)
            .Ignore(dto => dto.ConcurrencyStamp);
        CreateMap<UpdateBookDto, Book>()
            .IgnoreAuditedObjectProperties()
            .Ignore(dto => dto.Id)
            .Ignore(dto => dto.ExtraProperties)
            .Ignore(dto => dto.ConcurrencyStamp);
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
    }
}
