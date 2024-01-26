using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.User.DeleteUser
{
    internal class DeleteUserCommandHandler(IUserRepository userRepository) : IRequestHandler<DeleteUserCommand>
    {
        public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.Id);
            if (user is null)
                return;

            user.Active = false;
            user.UpdatedAt = DateTime.Now;

            await userRepository.SaveChangesAsync();
        }
    }
}
