using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Book.UpdateBook
{
    public class UpdateBookCommandHandler(IBookRepository bookRepository) : IRequestHandler<UpdateBookCommand>
    {
        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await bookRepository.GetBookByIdAsync(request.Id);
            if (book is null)
                return;

            book.Title = request.Title;
            book.Author = request.Author;
            book.Isbn = request.Isbn;
            book.PublishedYear = request.PublishedYear;
            book.UpdatedAt = DateTime.Now;

            await bookRepository.SaveChangesAsync();
        }
    }
}
