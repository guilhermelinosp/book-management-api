using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Book.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookByIdAsync(request.Id);
            if (book is null)
                return;

            book.Active = false;
            book.UpdatedAt = DateTime.Now;

            await _bookRepository.SaveChangesAsync();
        }
    }
}
