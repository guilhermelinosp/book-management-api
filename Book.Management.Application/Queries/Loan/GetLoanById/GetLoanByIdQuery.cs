using Book.Management.Application.ViewModels.Loan;
using MediatR;

namespace Book.Management.Application.Queries.Loan.GetLoanById
{
    public class GetLoanByIdQuery : IRequest<LoanDetailsViewModel>
    {
        public int Id { get; private set; }

        public GetLoanByIdQuery(int id)
        {
            Id = id;
        }
    }
}
