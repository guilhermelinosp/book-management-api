using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.User.CreateUser
{
    public class CreateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<CreateUserCommand, int>
    {
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.User(request.Name, request.Email, request.BirthDate);

            await userRepository.AddUserAsync(user);

            return user.Id;
        }
    }
}
