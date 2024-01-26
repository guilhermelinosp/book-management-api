using Book.Management.Application.ViewModels.Book;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookViewModel>>
    {
        public GetAllBooksQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
