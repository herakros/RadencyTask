using Radency.Contracts.DTO;
using Radency.Contracts.Queries;

namespace Radency.Contracts.Services
{
    public interface IBookService
    {
        Task<int> CreateOrUpdateBookAsync(CreateOrUpdateBookDTO model);
        Task<IEnumerable<OrderBookDTO>> GetAllBooks(QueryOrderBooks query);
        Task DeleteBookAsync(QuerySecretKey secretKey, int id);
        Task<BookDTO> GetBookByIdAsync(int id);
        Task<int> AddBookReview(int id, AddReviewDTO model);
        Task AddBookRate(int id, AddRaitingDTO model);
        Task<IEnumerable<OrderBookDTO>> GetRecommendedBooks(QueryBookGenre query);
    }
}
