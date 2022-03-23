using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commands
{
    public class CreateStreamerCommandValidator : AbstractValidator<CreateStreamerCommand>
    {
        public CreateStreamerCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{Nombre} es Obligatorio")
                .NotNull()
                .MaximumLength(50).WithMessage("{Nombre} no puede tener mas de 50 caracteres");

            RuleFor(p => p.Url)
                .NotEmpty().WithMessage("{Url} es Obligatoria");
        }
    }
}
