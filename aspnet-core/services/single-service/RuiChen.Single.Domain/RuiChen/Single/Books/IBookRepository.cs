using System;
using Volo.Abp.Domain.Repositories;

namespace RuiChen.Single.Books;

public interface IBookRepository : IRepository<Book, Guid>
{
}
