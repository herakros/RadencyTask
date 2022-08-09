using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Radency.Contracts.Data.Entities.RaitingEntity
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
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
                .WithMany(x => x.Reviews)
                .HasForeignKey(x => x.BookId);
        }
    }
}
