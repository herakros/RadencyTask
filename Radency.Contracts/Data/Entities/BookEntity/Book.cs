using Radency.Contracts.Data.Entities.RaitingEntity;
using Radency.Contracts.Data.Entities.ReviewEntity;

namespace Radency.Contracts.Data.Entities.BookEntity
{
    public class Book : IBaseEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Cover { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string Genve { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Raiting> Raitings { get; set; }
    }
}
