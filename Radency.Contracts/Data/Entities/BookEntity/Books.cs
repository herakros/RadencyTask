using Ardalis.Specification;

namespace Radency.Contracts.Data.Entities.BookEntity
{
    public class Books
    {
        public class BookReviews : Specification<Book>
        {
            public BookReviews(int bookId)
            {
                Query
                    .Include(x => x.Reviews)
                    .Include(x => x.Raitings)
                    .Where(x => x.Id == bookId);
            }
        }

        public class BookList : Specification<Book>
        {
            public BookList()
            {
                Query
                    .Include(x => x.Reviews)
                    .Include(x => x.Raitings);
            }
        }

        public class RecommendedBooks : Specification<Book>
        {
            public RecommendedBooks()
            {
                Query
                    .Include(x => x.Reviews)
                    .Include(x => x.Raitings);
            }
        }
    }
}
