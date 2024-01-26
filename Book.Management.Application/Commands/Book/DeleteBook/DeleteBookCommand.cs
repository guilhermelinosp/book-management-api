using MediatR;

namespace Book.Management.Application.Commands.Book.DeleteBook
{
    public class DeleteBookCommand : IRequest
    {
        public DeleteBookCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
