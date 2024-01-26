using MediatR;

namespace Book.Management.Application.Commands.Book.CreateBook
{
    public class CreateBookCommand : IRequest<int>
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Isbn { get; set; }
        public DateTime PublishedYear { get; set; }
    }
}
