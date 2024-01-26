using Book.Management.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookManagerDbContext _dbContext;
        public BookRepository(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Domain.Entities.Book>> GetAllBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Domain.Entities.Book> GetBookByIdAsync(int id)
        {
            return await _dbContext.Books.SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddBookAsync(Domain.Entities.Book book)
        {
            await _dbContext.Books.AddAsync(book);
            await SaveChangesAsync();
        }
    }
}
