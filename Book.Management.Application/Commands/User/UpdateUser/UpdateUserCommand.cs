using MediatR;

namespace Book.Management.Application.Commands.User.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        public UpdateUserCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
