using Book.Management.Application.ViewModels.Book;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
    {
        private readonly IBookRepository _bookRepository;
        public GetAllBooksQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllBooksAsync();
            var booksDetails = books
                .Where(x => x.Active)
                .Select(b => new BookViewModel(b.Id, b.Title, b.Author, b.Isbn, b.PublishedYear, b.CreatedAt))
                .ToList();

            return booksDetails;
        }
    }
}
