namespace Book.Management.Application.ViewModels.User
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullName, string email, DateTime birthDate)
        {
            Id = id;
            Name = fullName;
            Email = email;
            BirthDate = birthDate;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}