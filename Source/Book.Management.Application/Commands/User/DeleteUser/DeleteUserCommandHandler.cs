using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.User.DeleteUser
{
    internal class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.Id);
            if (user is null)
                return;

            user.Active = false;
            user.UpdatedAt = DateTime.Now;

            await _userRepository.SaveChangesAsync();
        }
    }
}
