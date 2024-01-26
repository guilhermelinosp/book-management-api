namespace Book.Management.Application.ViewModels.User
{
    public class UserDetailsViewModel(
        int id,
        string name,
        string email,
        DateTime birthDate,
        DateTime createdAt,
        DateTime updatedAt,
        bool active)
    {
        public int Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public string Email { get; private set; } = email;
        public DateTime BirthDate { get; private set; } = birthDate;
        public DateTime CreatedAt { get; private set; } = createdAt;
        public DateTime UpdatedAt { get; private set; } = updatedAt;
        public bool Active { get; private set; } = active;
    }
}