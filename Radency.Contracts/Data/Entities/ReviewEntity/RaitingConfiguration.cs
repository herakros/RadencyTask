using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Radency.Contracts.Data.Entities.ReviewEntity
{
    public class RaitingConfiguration : IEntityTypeConfiguration<Raiting>
    {
        public void Configure(EntityTypeBuilder<Raiting> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Score)
                .IsRequired();

            builder
                .HasOne(x => x.Book)
                .WithMany(x => x.Raitings)
                .HasForeignKey(x => x.BookId);
        }
    }
}
