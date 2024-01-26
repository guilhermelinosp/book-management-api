using Book.Management.Application.ViewModels.Book;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDetailsViewModel>
    {
        private readonly IBookRepository _bookRepository;
        public GetBookByIdQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDetailsViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookByIdAsync(request.Id);

            if (book is null)
                return null;

            var bookDetails = new BookDetailsViewModel(
                book.Id,
                book.Title,
                book.Author,
                book.Isbn,
                book.PublishedYear,
                book.CreatedAt);

            return bookDetails;
        }
    }
}
