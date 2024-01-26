namespace Book.Management.Domain.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int idUser, int idBook, int loanDays)
        {
            IdUser = idUser;
            IdBook = idBook;
            LoanDays = loanDays;

            LoanDate = DateTime.Now;
        }

        public int IdUser { get; private set; }
        public int IdBook { get; private set; }
        public int LoanDays { get; private set; }
        public DateTime LoanDate { get; private set; }

        public DateTime DevolutionDate { get; set; }
        public User User { get; private set; }
        public Book Book { get; private set; }
    }
}
