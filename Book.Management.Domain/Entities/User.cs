namespace Book.Management.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.MinValue;
            Active = true;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public DateTime CreatedAt { get; private set; }
        public List<Loan> Loans { get; private set; }

        public bool Active { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
