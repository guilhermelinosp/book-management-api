using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Book.DeleteBook
{
    public class DeleteBookCommandHandler(IBookRepository bookRepository) : IRequestHandler<DeleteBookCommand>
    {
        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await bookRepository.GetBookByIdAsync(request.Id);
            if (book is null)
                return;

            book.Active = false;
            book.UpdatedAt = DateTime.Now;

            await bookRepository.SaveChangesAsync();
        }
    }
}
