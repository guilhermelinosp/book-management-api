namespace Book.Management.Application.ViewModels.User
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(int id, string name, string email, DateTime birthDate, DateTime createdAt, DateTime updatedAt, bool active)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Active = active;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public bool Active { get; private set; }
    }
}