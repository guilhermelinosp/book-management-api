using Book.Management.Application.ViewModels.Book;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetBookById
{
    public class GetBookByIdQuery(int id) : IRequest<BookDetailsViewModel>
    {
        public int Id { get; private set; } = id;
    }
}
