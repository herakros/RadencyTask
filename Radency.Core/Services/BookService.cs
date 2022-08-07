using Radency.Contracts.Data;
using Radency.Contracts.Data.Entities.BookEntity;
using Radency.Contracts.Services;

namespace Radency.Core.Services
{
    public class BookService : IBookService
    {
        protected readonly IRepository<Book> _bookRepository;
        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAllAsync();
        }
    }
}
