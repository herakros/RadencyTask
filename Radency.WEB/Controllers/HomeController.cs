using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok();
        }

        [HttpGet]
        [Route("recommended")] // Get top 10 books with high rating and number of reviews greater than 10.
                               // You can filter books by specifying genre. Order by rating
        public async Task<IActionResult> GetRecommended()
        {
            return Ok();
        }

        [HttpGet]
        [Route("books/{id}")] // Get book details with the list of reviews

        public async Task<IActionResult> AddBook()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("books/{id}")] // Delete a book using a secret key. Save the secret key in the config of your application.
                              // Compare this key with query param
        public async Task<IActionResult> DeleteBookd()
        {
            return Ok();
        }

        [HttpPost]
        [Route("books/save")]
        public async Task<IActionResult> SaveBook()
        {
            return Ok();
        }

        [HttpPut]
        [Route("books/{id}/review")]
        public async Task<IActionResult> SaveBookReview()
        {
            return Ok();
        }

        [HttpPut]
        [Route("books/{id}/rate")]
        public async Task<IActionResult> ChangeBookRate()
        {
            return Ok();
        }
    }
}
