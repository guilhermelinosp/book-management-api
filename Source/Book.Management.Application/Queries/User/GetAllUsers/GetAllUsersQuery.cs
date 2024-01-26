using Book.Management.Application.ViewModels.User;
using MediatR;

namespace Book.Management.Application.Queries.User.GetAllUsers
{
    public class GetAllUsersQuery(string query) : IRequest<List<UserViewModel>>
    {
        public string Query { get; private set; } = query;
    }
}
