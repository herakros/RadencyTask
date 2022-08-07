using AutoMapper;
using Radency.Contracts.Data;
using Radency.Contracts.Data.Entities.BookEntity;
using Radency.Contracts.Data.Entities.RaitingEntity;
using Radency.Contracts.Data.Entities.ReviewEntity;
using Radency.Contracts.DTO;
using Radency.Contracts.Services;

namespace Radency.Core.Services
{
    public class BookService : IBookService
    {
        protected readonly IRepository<Book> _bookRepository;
        protected readonly IRepository<Review> _reviewRepository;
        protected readonly IRepository<Raiting> _raitingRepository;
        protected readonly IMapper _mapper;
        public BookService(IRepository<Book> bookRepository, 
            IMapper mapper,
            IRepository<Review> reviewRepository,
            IRepository<Raiting> raitingRepository)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _reviewRepository = reviewRepository;
            _raitingRepository = raitingRepository;
        }

        public async Task AddBookRate(int id, AddRaitingDTO model)
        {
            var book = await _bookRepository.GetByKeyAsync(id);

            if(book != null)
            {
                var raiting = new Raiting()
                {
                    BookId = id,
                    Book = book
                };

                raiting.Score = model.Score;

                await _raitingRepository.AddAsync(raiting);
                await _raitingRepository.SaveChangesAsync();
            }
        }

        public async Task<int> AddBookReview(int id, AddReviewDTO model)
        {
            var book = await _bookRepository.GetByKeyAsync(id);

            if(book != null)
            {
                var review = new Review()
                {
                    BookId = id,
                    Book = book
                };

                _mapper.Map(model, review);

                await _reviewRepository.AddAsync(review);
                await _reviewRepository.SaveChangesAsync();
            }

            return id;
        }

        public async Task<int> CreateOrUpdateBookAsync(CreateOrUpdateBookDTO model)
        {
            var book = await _bookRepository.GetByKeyAsync(model.Id);

            if(book != null)
            {
                _mapper.Map(model, book);

                await _bookRepository.UpdateAsync(book);
                await _bookRepository.SaveChangesAsync();

                return book.Id;
            }
            else
            {
                book = new Book();

                _mapper.Map(model, book);

                await _bookRepository.AddAsync(book);
                await _bookRepository.SaveChangesAsync();

                return book.Id;
            }
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetByKeyAsync(id);

            if(book != null)
            {
                await _bookRepository.DeleteAsync(book);
                await _bookRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OrderBookDTO>> GetAllBooks(string order)
        {
            var books = await _bookRepository.GetAllAsync();
            var orderBooks = new List<OrderBookDTO>();

            _mapper.Map(books, orderBooks);

            if(order == "title")
            {
                return orderBooks.OrderBy(x => x.Title);
            }
            else
            {
                return orderBooks.OrderBy(x => x.Author);
            }
        }

        public async Task<BookDTO> GetBookByIdAsync(int id)
        {
            var specification = new Books.BookReviews(id);
            var book = await _bookRepository.GetFirstBySpecAsync(specification);

            if(book != null)
            {
                var bookDTO = new BookDTO();

                _mapper.Map(book, bookDTO);

                return bookDTO;
            }

            return new BookDTO();
        }
    }
}
