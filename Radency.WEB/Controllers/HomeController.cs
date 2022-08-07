using Microsoft.AspNetCore.Mvc;
using Radency.Contracts.DTO;
using Radency.Contracts.Services;

namespace Radency.WEB.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        protected readonly IBookService _bookService;

        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("books")] // Get all books. Order by provided value (title or author)
        public async Task<IActionResult> GetAllBooks([FromQuery] string order)
        {
            var result = await _bookService.GetAllBooks(order);
            return Ok(result);
        }

        [HttpGet]
        [Route("recommended")] // Get top 10 books with high rating and number of reviews greater than 10.
                               // You can filter books by specifying genre. Order by rating
        public async Task<IActionResult> GetRecommendedBooks([FromQuery] string genre)
        {

            return Ok();
        }

        [HttpGet]
        [Route("books/{id}")] // Get book details with the list of reviews

        public async Task<IActionResult> GetBookById(int id)
        {
            var result = await _bookService.GetBookByIdAsync(id);
            return Ok(result);
        }

        [HttpDelete]
        [Route("books/{id}")] // Delete a book using a secret key. Save the secret key in the config of your application.
                              // Compare this key with query param
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookService.DeleteBookAsync(id);
            return Ok();
        }

        [HttpPost]
        [Route("books/save")]
        public async Task<IActionResult> CreateOrUpdateBook([FromBody] CreateOrUpdateBookDTO model)
        {
            var result = await _bookService.CreateOrUpdateBookAsync(model);
            return Ok(result);
        }

        [HttpPut]
        [Route("books/{id}/review")]
        public async Task<IActionResult> SaveBookReview(int id, [FromBody] AddReviewDTO model)
        {
            var result = await _bookService.AddBookReview(id, model);
            return Ok(result);
        }

        [HttpPut]
        [Route("books/{id}/rate")]
        public async Task<IActionResult> ChangeBookRate(int id, [FromBody] AddRaitingDTO model)
        {
            await _bookService.AddBookRate(id, model);
            return Ok();
        }
    }
}
