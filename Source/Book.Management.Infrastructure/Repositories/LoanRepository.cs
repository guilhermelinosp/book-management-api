using Book.Management.Domain.Entities;
using Book.Management.Domain.Repositories;
using Book.Management.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Book.Management.Infrastructure.Repositories
{
    public class LoanRepository(ManagementDbContext dbContext) : ILoanRepository
    {
        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task AddLoanAsync(Loan loan)
        {
            await dbContext.Loans!.AddAsync(loan);
            await SaveChangesAsync();
        }

        public async Task<Loan?> GetLoanByIdAsync(int id)
        {
            return await dbContext.Loans!.SingleOrDefaultAsync(b => b.Id == id);
        }
    }
}
