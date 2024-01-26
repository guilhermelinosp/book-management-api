namespace Book.Management.Application.ViewModels.User
{
	public class UserViewModel(int id, string fullName, string email, DateTime birthDate)
	{
		public int Id { get; private set; } = id;
		public string Name { get; private set; } = fullName;
		public string Email { get; private set; } = email;
		public DateTime BirthDate { get; private set; } = birthDate;
	}
}