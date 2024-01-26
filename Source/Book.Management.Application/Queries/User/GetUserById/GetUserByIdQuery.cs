using Book.Management.Application.ViewModels.User;
using MediatR;

namespace Book.Management.Application.Queries.User.GetUserById
{
    public class GetUserByIdQuery(int id) : IRequest<UserDetailsViewModel>
    {
        public int Id { get; private set; } = id;
    }
}
