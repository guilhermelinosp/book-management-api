using Book.Management.Application.ViewModels.Book;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetAllBooks
{
    public class GetAllBooksQueryHandler(IBookRepository bookRepository)
        : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
    {
        public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await bookRepository.GetAllBooksAsync();
            var booksDetails = books
                .Where(x => x.Active)
                .Select(b => new BookViewModel(b.Id, b.Title, b.Author, b.Isbn, b.PublishedYear, b.CreatedAt))
                .ToList();

            return booksDetails;
        }
    }
}
