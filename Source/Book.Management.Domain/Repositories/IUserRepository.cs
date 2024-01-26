using Book.Management.Domain.Entities;

namespace Book.Management.Domain.Repositories
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsersAsync();
        public Task<User?> GetUserByIdAsync(int id);
        public Task AddUserAsync(User book);
        public Task SaveChangesAsync();
    }
}
