using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Loan.CreateLoan
{
    public class CreateLoanCommandHandler(ILoanRepository loanRepository) : IRequestHandler<CreateLoanCommand, int>
    {
        public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Domain.Entities.Loan(request.IdUser, request.IdBook, request.LoanDays);

            await loanRepository.AddLoanAsync(loan);

            return loan.Id;
        }
    }
}
