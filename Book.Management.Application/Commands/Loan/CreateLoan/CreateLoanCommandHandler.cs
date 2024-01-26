using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.Loan.CreateLoan
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, int>
    {
        private readonly ILoanRepository _loanRepository;

        public CreateLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Domain.Entities.Loan(request.IdUser, request.IdBook, request.LoanDays);

            await _loanRepository.AddLoanAsync(loan);

            return loan.Id;
        }
    }
}
