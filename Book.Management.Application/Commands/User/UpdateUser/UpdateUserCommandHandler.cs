using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Commands.User.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.Id);
            if (user is null)
                return;

            user.Name = request.Name;
            user.Email = request.Email;
            user.BirthDate = request.BirthDate;

            user.UpdatedAt = DateTime.Now;

            await _userRepository.SaveChangesAsync();
        }
    }
}
