using Radency.Contracts.Data.Entities.BookEntity;

namespace Radency.Contracts.Data.Entities.ReviewEntity
{
    public class Raiting : IBaseEntity
    {
        public int Id { get; set; }

        public Book Book { get; set; }

        public int BookId { get; set; }

        public decimal Score { get; set; }
    }
}
