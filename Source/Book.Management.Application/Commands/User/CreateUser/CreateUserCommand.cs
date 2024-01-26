using MediatR;

namespace Book.Management.Application.Commands.User.CreateUser
{
	public class CreateUserCommand : IRequest<int>
	{
		public required string Name { get; set; }
		public required string Email { get; set; }
		public DateTime BirthDate { get; set; }
	}
}