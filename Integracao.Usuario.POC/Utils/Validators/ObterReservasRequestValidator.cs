using FluentValidation;
using Integracao.Usuario.POC.Models;

namespace Integracao.Usuario.POC.Utils.Validators
{
    public class ObterReservasRequestValidator : AbstractValidator<ObterReservasRequest>
    {
        public ObterReservasRequestValidator()
        {
            RuleFor(x => x.HospedeId).NotEmpty().WithMessage("HospedeId é obrigatório.")
                .GreaterThan(0).WithMessage("HospedeId deve ser maior que zero.");
        }
    }
}
