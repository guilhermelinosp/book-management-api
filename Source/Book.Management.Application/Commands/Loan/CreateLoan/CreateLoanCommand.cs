using MediatR;

namespace Book.Management.Application.Commands.Loan.CreateLoan
{
    public class CreateLoanCommand : IRequest<int>
    {
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public int LoanDays { get; set; }
    }
}
