using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Book.CreateBook
{
    public class CreateBookCommandHandler(IBookRepository bookRepository) : IRequestHandler<CreateBookCommand, int>
    {
        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Domain.Entities.Book(request.Title, request.Author, request.Isbn, request.PublishedYear);

            await bookRepository.AddBookAsync(book);

            return book.Id;
        }
    }
}
