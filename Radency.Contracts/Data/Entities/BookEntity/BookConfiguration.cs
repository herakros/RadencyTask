using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Radency.Contracts.Data.Entities.BookEntity
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Title)
                .IsRequired();

            builder
                .Property(x => x.Cover)
                .IsRequired();

            builder
                .Property(x => x.Content)
                .IsRequired();

            builder
                .Property(x => x.Author)
                .IsRequired();

            builder
                .Property(x => x.Genre)
                .IsRequired();

        }
    }
}
