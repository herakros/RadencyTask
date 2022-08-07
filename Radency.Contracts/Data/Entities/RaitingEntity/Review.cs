using Radency.Contracts.Data.Entities.BookEntity;

namespace Radency.Contracts.Data.Entities.RaitingEntity
{
    public class Review : IBaseEntity
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public Book Book { get; set; }

        public int BookId { get; set; }

        public string Reviewer { get; set; }
    }
}
