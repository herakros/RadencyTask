using Radency.Contracts.DTO;

namespace Radency.Contracts.Services
{
    public interface IBookService
    {
        Task<int> CreateOrUpdateBookAsync(CreateOrUpdateBookDTO model);
        Task<IEnumerable<OrderBookDTO>> GetAllBooks(string order);
        Task DeleteBookAsync(int id);
        Task<BookDTO> GetBookByIdAsync(int id);
        Task<int> AddBookReview(int id, AddReviewDTO model);
        Task AddBookRate(int id, AddRaitingDTO model);
    }
}
