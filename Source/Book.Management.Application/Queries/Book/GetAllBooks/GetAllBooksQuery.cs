using Book.Management.Application.ViewModels.Book;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetAllBooks
{
    public class GetAllBooksQuery(string query) : IRequest<List<BookViewModel>>
    {
        public string Query { get; private set; } = query;
    }
}
