using MediatR;

namespace Book.Management.Application.Commands.User.DeleteUser
{
    public class DeleteUserCommand(int id) : IRequest
    {
        public int Id { get; private set; } = id;
    }
}
