using Book.Management.Domain.Repositories;
using Book.Management.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Repositories
{
	public class BookRepository(ManagementDbContext dbContext) : IBookRepository
	{
		public async Task<List<Domain.Entities.Book>> GetAllBooksAsync()
		{
			return await dbContext.Books!.ToListAsync();
		}

		public async Task<Domain.Entities.Book?> GetBookByIdAsync(int id)
		{
			return await dbContext.Books!.SingleOrDefaultAsync(b => b.Id == id);
		}

		public async Task SaveChangesAsync()
		{
			await dbContext.SaveChangesAsync();
		}

		public async Task AddBookAsync(Domain.Entities.Book book)
		{
			await dbContext.Books!.AddAsync(book);
			await SaveChangesAsync();
		}
	}
}