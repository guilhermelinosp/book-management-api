using Book.Management.Domain.Entities;
using Book.Management.Domain.Repositories;
using Book.Management.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Repositories
{
	public class UserRepository(ManagementDbContext dbContext) : IUserRepository
	{
		public async Task<List<User>> GetAllUsersAsync()
		{
			return await dbContext.Users!.ToListAsync();
		}

		public async Task<User?> GetUserByIdAsync(int id)
		{
			return await dbContext.Users!.SingleOrDefaultAsync(b => b.Id == id);
		}

		public async Task SaveChangesAsync()
		{
			await dbContext.SaveChangesAsync();
		}

		public async Task AddUserAsync(User book)
		{
			await dbContext.Users!.AddAsync(book);
			await SaveChangesAsync();
		}
	}
}