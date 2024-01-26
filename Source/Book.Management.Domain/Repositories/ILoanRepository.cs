using Book.Management.Domain.Entities;

namespace Book.Management.Domain.Repositories
{
    public interface ILoanRepository
    {
        public Task SaveChangesAsync();
        public Task AddLoanAsync(Loan loan);
        public Task<Loan?> GetLoanByIdAsync(int id);
    }
}
