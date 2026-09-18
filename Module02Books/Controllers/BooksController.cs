using Microsoft.AspNetCore.Mvc;
using Module02Books.Models;

namespace Module02Books.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static readonly List<Book> books = new()
        {
            new Book
            {
                Id = 1,
                Title = "1984",
                Author = "George Orwell",
                Year = 1949
            },

            new Book
            {
                Id = 2,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Year = 1937
            },

            new Book
            {
                Id = 3,
                Title = "Harry Potter",
                Author = "J.K. Rowling",
                Year = 1997
            }
        };

        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            return Ok(books);
        }

        // POST: api/books
        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            books.Add(book);

            return Created("", book);
        }
    }
}