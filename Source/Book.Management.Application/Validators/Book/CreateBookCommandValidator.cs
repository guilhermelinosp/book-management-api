using Book.Management.Application.Commands.Book.CreateBook;
using FluentValidation;

namespace Book.Management.Application.Validators.Book
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(b => b.Title)
                .NotEmpty()
                .NotNull()
                .WithMessage("Título inválido");

            RuleFor(b => b.Author)
                .NotEmpty()
                .NotNull()
                .WithMessage("Autor inválido");
        }
    }
}
