using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Radency.Contracts.Data.Entities.RaitingEntity
{
    public class RaitingConfiguration : IEntityTypeConfiguration<Raiting>
    {
        public void Configure(EntityTypeBuilder<Raiting> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Message)
                .IsRequired();

            builder
                .Property(x => x.Reviewer)
                .IsRequired();

            builder
                .HasOne(x => x.Book)
                .WithMany(x => x.Raitings)
                .HasForeignKey(x => x.BookId);
        }
    }
}
