using MediatR;

namespace Book.Management.Application.Commands.User.UpdateUser
{
    public class UpdateUserCommand(int id, string name, string email) : IRequest
    {
        public int Id { get; private set; } = id;
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public DateTime BirthDate { get; set; }
    }
}
