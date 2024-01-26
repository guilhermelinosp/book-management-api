using Book.Management.Domain.Entities;
using Book.Management.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly BookManagerDbContext _dbContext;
        public LoanRepository(BookManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddLoanAsync(Loan loan)
        {
            await _dbContext.Loans.AddAsync(loan);
            await SaveChangesAsync();
        }

        public async Task<Loan> GetLoanByIdAsync(int id)
        {
            return await _dbContext.Loans.SingleOrDefaultAsync(b => b.Id == id);
        }
    }
}
