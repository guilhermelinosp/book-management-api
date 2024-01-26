namespace Book.Management.Domain.Entities
{
	public class User(string name, string email, DateTime birthDate) : BaseEntity
	{
		public string Name { get; set; } = name;
		public string Email { get; set; } = email;
		public DateTime BirthDate { get; set; } = birthDate;

		public DateTime CreatedAt { get; private set; } = DateTime.Now;
		public List<Loan>? Loans { get; private set; }

		public bool Active { get; set; } = true;
		public DateTime UpdatedAt { get; set; } = DateTime.MinValue;
	}
}