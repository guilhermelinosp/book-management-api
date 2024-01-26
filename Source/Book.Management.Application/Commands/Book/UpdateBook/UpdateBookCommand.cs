using MediatR;

namespace Book.Management.Application.Commands.Book.UpdateBook
{
	public class UpdateBookCommand : IRequest
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public required string Author { get; set; }
		public required string Isbn { get; set; }
		public DateTime PublishedYear { get; set; }
	}
}