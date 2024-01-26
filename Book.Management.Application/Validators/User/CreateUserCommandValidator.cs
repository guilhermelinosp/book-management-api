using Book.Management.Application.Commands.User.CreateUser;
using FluentValidation;

namespace Book.Management.Application.Validators.User
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("E-mail inválido!");

            RuleFor(u => u.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("O nome não pode ser nulo ou vazio");
        }
    }
}
