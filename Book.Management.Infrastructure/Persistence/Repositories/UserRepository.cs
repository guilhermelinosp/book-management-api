using Book.Management.Domain.Entities;
using Book.Management.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookManagerDbContext _dbContext;

        public UserRepository(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddUserAsync(User book)
        {
            await _dbContext.Users.AddAsync(book);
            await SaveChangesAsync();
        }
    }
}
