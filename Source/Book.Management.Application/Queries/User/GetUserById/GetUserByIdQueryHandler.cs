using Book.Management.Application.ViewModels.User;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.User.GetUserById
{
    public class GetUserByIdQueryHandler(IUserRepository userRepository)
        : IRequestHandler<GetUserByIdQuery, UserDetailsViewModel>
    {
        public async Task<UserDetailsViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.Id);

            return new UserDetailsViewModel(
                user!.Id,
                user.Name,
                user.Email,
                user.BirthDate,
                user.CreatedAt,
                user.UpdatedAt,
                user.Active);
        }
    }
}
