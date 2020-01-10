using FluentValidation;
using Integracao.Usuario.POC.Models;

namespace Integracao.Usuario.POC.Utils.Validators
{
    public class ObterReservasRequestValidator : AbstractValidator<ObterReservasRequest>
    {
        public ObterReservasRequestValidator()
        {
            RuleFor(x => x.Documento).NotEmpty().WithMessage("Documento é obrigatório.").
                Length(11, 11).WithMessage("CPF com tamanho inválido.");
        }
    }
}
