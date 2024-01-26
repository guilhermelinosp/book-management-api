using Book.Management.Application.Commands.User.CreateUser;
using Book.Management.Application.Commands.User.DeleteUser;
using Book.Management.Application.Commands.User.UpdateUser;
using Book.Management.Application.Queries.User.GetAllUsers;
using Book.Management.Application.Queries.User.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Book.Management.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers(string query)
        {
            var command = new GetAllUsersQuery(query);
            var users = await _mediator.Send(command);

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var command = new GetUserByIdQuery(id);
            var user = await _mediator.Send(command);

            return user is null
                ? NotFound()
                : Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetUserById), new { id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            var deleteUser = new DeleteUserCommand(id);
            await _mediator.Send(deleteUser);
            return NoContent();
        }
    }
}
