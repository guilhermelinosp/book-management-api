using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Book.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookRepository _bookRepository;

        public UpdateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookByIdAsync(request.Id);
            if (book is null)
                return;

            book.Title = request.Title;
            book.Author = request.Author;
            book.Isbn = request.Isbn;
            book.PublishedYear = request.PublishedYear;
            book.UpdatedAt = DateTime.Now;

            await _bookRepository.SaveChangesAsync();
        }
    }
}
