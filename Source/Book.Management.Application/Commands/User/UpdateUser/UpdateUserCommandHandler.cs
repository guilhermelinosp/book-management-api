using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.User.UpdateUser
{
    public class UpdateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<UpdateUserCommand>
    {
        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.Id);
            if (user is null)
                return;

            user.Name = request.Name;
            user.Email = request.Email;
            user.BirthDate = request.BirthDate;

            user.UpdatedAt = DateTime.Now;

            await userRepository.SaveChangesAsync();
        }
    }
}
