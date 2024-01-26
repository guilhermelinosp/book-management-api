using MediatR;

namespace Book.Management.Application.Commands.Book.CreateBook
{
    public class CreateBookCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime PublishedYear { get; set; }
    }
}
