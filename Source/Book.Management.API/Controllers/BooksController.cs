using Book.Management.Application.Commands.Book.CreateBook;
using Book.Management.Application.Commands.Book.DeleteBook;
using Book.Management.Application.Commands.Book.UpdateBook;
using Book.Management.Application.Queries.Book.GetAllBooks;
using Book.Management.Application.Queries.Book.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Book.Management.API.Controllers
{
    [Route("api/books")]
    public class BooksController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBooks(string query)
        {
            var command = new GetAllBooksQuery(query);
            var books = await mediator.Send(command);

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var command = new GetBookByIdQuery(id);
            var book = await mediator.Send(command);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterNewBook([FromBody] CreateBookCommand command)
        {
            var id = await mediator.Send(command);
            return CreatedAtAction(nameof(GetBookById), new { id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] UpdateBookCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookById(int id)
        {
            var deleteBook = new DeleteBookCommand(id);
            await mediator.Send(deleteBook);

            return NoContent();
        }
    }
}
