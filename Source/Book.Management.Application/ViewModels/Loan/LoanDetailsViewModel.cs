namespace Book.Management.Application.ViewModels.Loan
{
    public class LoanDetailsViewModel
    {
        public LoanDetailsViewModel(int idUser, int idBook, int loanDays, DateTime loanDate)
        {
            IdUser = idUser;
            IdBook = idBook;
            LoanDays = loanDays;
            LoanDate = loanDate;
        }
         
        public int IdUser { get; private set; }
        public int IdBook { get; private set; }
        public int LoanDays { get; private set; }
        public DateTime LoanDate { get; private set; }
    }
}
