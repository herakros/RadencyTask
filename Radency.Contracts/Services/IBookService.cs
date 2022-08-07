using Radency.Contracts.Data.Entities.BookEntity;

namespace Radency.Contracts.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
