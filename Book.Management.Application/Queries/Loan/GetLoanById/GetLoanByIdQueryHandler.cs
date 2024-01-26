using Book.Management.Application.ViewModels.Loan;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.Loan.GetLoanById
{
    public class GetLoanByIdQueryHandler : IRequestHandler<GetLoanByIdQuery, LoanDetailsViewModel>
    {
        private readonly ILoanRepository _loanRepository;
        public GetLoanByIdQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }


        public async Task<LoanDetailsViewModel> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetLoanByIdAsync(request.Id);
            if (loan is null)
                return null;

            var loanDetails = new LoanDetailsViewModel(
                loan.IdUser,
                loan.IdBook,
                loan.LoanDays,
                loan.LoanDate);

            return loanDetails;
        }
    }
}
