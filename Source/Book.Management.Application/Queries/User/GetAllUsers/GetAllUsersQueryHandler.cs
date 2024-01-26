using Book.Management.Application.ViewModels.User;
using Book.Management.Domain.Repositories;
using MediatR;

namespace Book.Management.Application.Queries.User.GetAllUsers
{
    public class GetAllUsersQueryHandler(IUserRepository userRepository)
        : IRequestHandler<GetAllUsersQuery, List<UserViewModel>>
    {
        public async Task<List<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await userRepository.GetAllUsersAsync();
            var userDetails = users
                    .Select(u => new UserViewModel(u.Id, u.Name, u.Email, u.BirthDate))
                    .ToList();

            return userDetails;
        }
    }
}
