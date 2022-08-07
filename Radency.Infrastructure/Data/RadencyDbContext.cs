using Microsoft.EntityFrameworkCore;
using Radency.Contracts.Data.Entities.BookEntity;
using Radency.Contracts.Data.Entities.RaitingEntity;
using Radency.Contracts.Data.Entities.ReviewEntity;

namespace Radency.Infrastructure.Data
{
    public class RadencyDbContext : DbContext
    {
        public RadencyDbContext(DbContextOptions<RadencyDbContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new RaitingConfiguration());

            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Raiting>().ToTable("Raiting");
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Raiting> Raitings { get; set; }
    }
}
