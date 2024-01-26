using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.User(request.Name, request.Email, request.BirthDate);

            await _userRepository.AddUserAsync(user);

            return user.Id;
        }
    }
}
