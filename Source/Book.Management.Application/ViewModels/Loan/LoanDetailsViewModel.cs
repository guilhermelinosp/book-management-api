namespace Book.Management.Application.ViewModels.Loan
{
    public class LoanDetailsViewModel(int idUser, int idBook, int loanDays, DateTime loanDate)
    {
        public int IdUser { get; private set; } = idUser;
        public int IdBook { get; private set; } = idBook;
        public int LoanDays { get; private set; } = loanDays;
        public DateTime LoanDate { get; private set; } = loanDate;
    }
}
