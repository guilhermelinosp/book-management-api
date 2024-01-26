using MediatR;

namespace Book.Management.Application.Commands.Book.DeleteBook
{
    public class DeleteBookCommand(int id) : IRequest
    {
        public int Id { get; private set; } = id;
    }
}
