using JetBrains.Annotations;
using RuiChen.Abp.DataProtection;
using RuiChen.Abp.DataProtection.EntityFrameworkCore;
using RuiChen.Single.EntityFrameworkCore;
using System;
using Volo.Abp.EntityFrameworkCore;

namespace RuiChen.Single.Books;

public class EfCoreBookRepository : EfCoreDataProtectionRepository<SingleDbContext, Book, Guid, BookAuth>, IBookRepository
{
    public EfCoreBookRepository(
        [NotNull] IDbContextProvider<SingleDbContext> dbContextProvider,
        [NotNull] IDataAuthorizationService dataAuthorizationService,
        [NotNull] IEntityTypeFilterBuilder entityTypeFilterBuilder,
        [NotNull] IEntityPropertyResultBuilder entityPropertyResultBuilder)
        : base(dbContextProvider, dataAuthorizationService, entityTypeFilterBuilder, entityPropertyResultBuilder)
    {
    }
}
