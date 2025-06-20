using Microsoft.EntityFrameworkCore;
using RuiChen.Abp.DataProtection.EntityFrameworkCore;
using RuiChen.Single.Authors;
using RuiChen.Single.Books;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace RuiChen.Single.EntityFrameworkCore;

public static class SingleDbContextModelCreatingExtensions
{

    public static void ConfigureSingle(
        this ModelBuilder builder,
        Action<SingleModelBuilderConfigurationOptions>? optionsAction = null)
    {
        Check.NotNull(builder, nameof(builder));

        var options = new SingleModelBuilderConfigurationOptions(
            SingleDbProterties.DbTablePrefix,
            SingleDbProterties.DbSchema
        );
        optionsAction?.Invoke(options);

        builder.Entity<Book>(b =>
        {
            b.ToTable(options.TablePrefix + "Books", options.Schema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);

            // ADD THE MAPPING FOR THE RELATION
            b.HasOne<Author>().WithMany().HasForeignKey(x => x.AuthorId).IsRequired();
        });

        builder.ConfigureEntityAuth<Book, Guid, BookAuth>();
    }

}
