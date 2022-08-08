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

        public class BookListOrderByTitle : Specification<Book>
        {
            public BookListOrderByTitle()
            {
                Query
                    .Include(x => x.Reviews)
                    .Include(x => x.Raitings)
                    .OrderBy(x => x.Title);
            }
        }

        public class BookListOrderByAuthor : Specification<Book>
        {
            public BookListOrderByAuthor()
            {
                Query
                    .Include(x => x.Reviews)
                    .Include(x => x.Raitings)
                    .OrderBy(x => x.Author);
            }
        }

        public class RecommendedBooks : Specification<Book>
        {
            public RecommendedBooks()
            {
                Query
                    .Include(x => x.Reviews)
                    .Include(x => x.Raitings)
                    .Take(10)
                    .Where(x => x.Reviews.Count > 10);
            }
        }
    }
}
