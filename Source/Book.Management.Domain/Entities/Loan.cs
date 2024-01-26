namespace Book.Management.Domain.Entities
{
	public class Loan(int idUser, int idBook, int loanDays)
		: BaseEntity
	{
		public int IdUser { get; private set; } = idUser;
		public int IdBook { get; private set; } = idBook;
		public int LoanDays { get; private set; } = loanDays;
		public DateTime LoanDate { get; private set; } = DateTime.Now;

		public DateTime DevolutionDate { get; set; }
		public User? User { get; private set; }
		public Book? Book { get; private set; }
	}
}