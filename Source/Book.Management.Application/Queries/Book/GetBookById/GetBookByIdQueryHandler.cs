using Book.Management.Application.ViewModels.Book;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.Book.GetBookById
{
	public class GetBookByIdQueryHandler(IBookRepository bookRepository)
		: IRequestHandler<GetBookByIdQuery, BookDetailsViewModel>
	{
		public async Task<BookDetailsViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
		{
			var book = await bookRepository.GetBookByIdAsync(request.Id);
			
			var bookDetails = new BookDetailsViewModel(
				book!.Id,
				book.Title,
				book.Author,
				book.Isbn,
				book.PublishedYear,
				book.CreatedAt);

			return bookDetails;
		}
	}
}