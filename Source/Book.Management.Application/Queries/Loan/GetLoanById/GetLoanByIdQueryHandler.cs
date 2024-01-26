using Book.Management.Application.ViewModels.Loan;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.Loan.GetLoanById
{
	public class GetLoanByIdQueryHandler(ILoanRepository loanRepository)
		: IRequestHandler<GetLoanByIdQuery, LoanDetailsViewModel>
	{
		public async Task<LoanDetailsViewModel> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
		{
			var loan = await loanRepository.GetLoanByIdAsync(request.Id);

			var loanDetails = new LoanDetailsViewModel(
				loan!.IdUser,
				loan.IdBook,
				loan.LoanDays,
				loan.LoanDate);

			return loanDetails;
		}
	}
}